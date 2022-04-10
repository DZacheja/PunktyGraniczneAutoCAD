/*
 * Wczytywanie punktów granicznych do rysunku AutoCAD
 * autor: Damian Zacheja
 */
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;
using DZacheja_PunktyGraniczne;

namespace DamianAutoCAD {
    public class PunktyGraniczne {
        private List<ObjectId> ToSelect;
        public bool error = false;
        public string errorMessage;

        /// <summary>
        /// Wczytanie bloków z punktami stabilizowanymi/niestabilizowanymi do rysunku
        /// </summary>
        public void ImportBlks() {
            Document ThisDoc = Application.DocumentManager.MdiActiveDocument;
            DocumentCollection dm = Application.DocumentManager;
            Database thisDb = dm.MdiActiveDocument.Database;
            Database sourceDb = new Database(false, true);
            string cDir = System.IO.Directory.GetCurrentDirectory();
            string sFile = @"PunktGraniczny.dwg";

            //Odczytywanie innego pliku DWG....
            sourceDb.ReadDwgFile(sFile, System.IO.FileShare.Read, true, "");

            //Lista bloków  w pliku...
            ObjectIdCollection blocksIds = new ObjectIdCollection();
            Autodesk.AutoCAD.DatabaseServices.TransactionManager tm = sourceDb.TransactionManager;
            using (Transaction tr = tm.StartTransaction()) {
                //Open BlockTable
                BlockTable bt = (BlockTable)tm.GetObject(sourceDb.BlockTableId, OpenMode.ForRead, false);
                foreach (ObjectId obj in bt) {
                    BlockTableRecord btr = (BlockTableRecord)tm.GetObject(obj, OpenMode.ForRead, false);

                    //Wybierz tylko nazwane oraz nie-warstwy...
                    if (!btr.IsAnonymous && !btr.IsLayout) {
                        blocksIds.Add(obj);
                        btr.Dispose();
                    }
                }
            }

            //Przepisanie znalezionych bloków do innego pliku...
            IdMapping mapping = new IdMapping();
            sourceDb.WblockCloneObjects(blocksIds, thisDb.BlockTableId, mapping, DuplicateRecordCloning.Ignore, false);
            sourceDb.Dispose();

        }

        /// <summary>
        /// Wstawanie bloku punktu w odpowiednie miejsce z odpowiednimi atrybutami
        /// </summary>
        /// <param name="dane">Kolekcja zawieająca parametry punktu</param>
        public void AddBlockWithAttributes(PunktGraniczny pkt) {
            {
                Document doc = Application.DocumentManager.MdiActiveDocument;
                Database db = doc.Database;
                using (DocumentLock docLoc = doc.LockDocument()) {
                    string BlockName = "";
                    BlockName = "PunktGranicznyNiestabilizowany";
                    if (!String.IsNullOrEmpty(pkt.STB)) {
                        if (Convert.ToInt32(pkt.STB) > 2) {
                            BlockName = "PunktGranicznyStabilizowany";
                        }
                    }
                    Transaction tr = db.TransactionManager.StartTransaction();
                    using (tr) {
                        //Pobierz definicje bloku...
                        BlockTable bt = db.BlockTableId.GetObject(OpenMode.ForRead) as BlockTable;
                        BlockTableRecord blockDef = bt[BlockName].GetObject(OpenMode.ForRead) as BlockTableRecord;

                        //Otwórz modelspace do wpisania bloku
                        BlockTableRecord ms = bt[BlockTableRecord.ModelSpace].GetObject(OpenMode.ForWrite) as BlockTableRecord;

                        //Tworzenie nowego bloku..
                        //Punkt wstawienia
                        double X, Y;
                        X = pkt.X;
                        Y = pkt.Y;

                        Point3d insPT = new Point3d(X, Y, 0);
                        BlockReference block = new BlockReference(insPT, blockDef.ObjectId);
                        block.Layer = pkt.layer;

                        ms.AppendEntity(block);
                        tr.AddNewlyCreatedDBObject(block, true);
                        foreach (ObjectId obID in blockDef) {
                            DBObject obj = obID.GetObject(OpenMode.ForRead);
                            AttributeDefinition attDef = obj as AttributeDefinition;
                            if ((attDef != null) && (!attDef.Constant)) {
                                using (AttributeReference attRef = new AttributeReference()) {
                                    attRef.SetAttributeFromBlock(attDef, block.BlockTransform);
                                    attRef.TextString = pkt.SetValueByTag(attRef.Tag);
                                    if (attRef.Tag == "ID") {
                                        attRef.Height = pkt.txtHeight;
                                    }
                                    block.AttributeCollection.AppendAttribute(attRef);
                                    tr.AddNewlyCreatedDBObject(attRef, true);

                                }
                            }
                        }
                        tr.Commit();


                    }
                }

            }
        }

        public void WykonajSelekcje(Dictionary<string, string> wybory) {
            ToSelect = new List<ObjectId>();
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor edt = doc.Editor;
            Transaction tr = db.TransactionManager.StartTransaction();
            using (DocumentLock dLock = doc.LockDocument()) {
                using (tr) {
                    if (wybory.ContainsKey("Layer")) {
                        //Dodanie wybranej warstwy jeżeli nie istnieje...
                        PozyskanieInformacjiDWG.AddLayer(wybory["Layer"]);
                    }
                    TypedValue[] filter = new TypedValue[2];
                    filter[0] = new TypedValue(0, "INSERT");
                    filter[1] = new TypedValue(2, "PunktGranicznyStabilizowany,PunktGranicznyNiestabilizowany");

                    SelectionFilter SFilter = new SelectionFilter(filter);
                    PromptSelectionOptions pso = new PromptSelectionOptions();

                    //Wybór wszystkich elementów spełniających kryteria...
                    PromptSelectionResult psr = edt.SelectAll(SFilter);
                    if (psr.Status != PromptStatus.OK) {
                        error = true;
                        errorMessage = "Nie znaleziono wczytanych punktów granicznych!";
                        edt.WriteMessage(errorMessage);
                        return;
                    }

                    SelectionSet ss = psr.Value;
                    ObjectId[] ThisObjCol = ss.GetObjectIds();
                    foreach (ObjectId ID in ThisObjCol) {
                        BlockReference br = (BlockReference)tr.GetObject(ID, OpenMode.ForWrite);

                        AttributeCollection attCol = br.AttributeCollection;
                        foreach (ObjectId atID in attCol) {
                            //Funckja dla odpowiedniego atrybutu w zależności od wybranej kombinacji
                            AttributeReference atr = (AttributeReference)tr.GetObject(atID, OpenMode.ForRead);
                            if (atr.Tag == wybory["Type"]) {
                                if (CheckValueOfAttribute(atr.TextString, wybory["Equals"], wybory["Value"]))
                                    if (!ToSelect.Contains(ID)) {
                                        ToSelect.Add(ID);
                                    }
                            }
                        }
                    }

                    tr.Abort();
                    SelectFound(wybory);
                }
            }

        }
        private bool CheckValueOfAttribute(string Value, string Equals, string Comparison) {
            //Funckja switch - case w zalezności od typu porównania....
            int vl, cmp;
            switch (Equals) {
                case "=":
                    return (Value == Comparison) ? true : false;
                case ">":
                    if (int.TryParse(Value, out vl) && int.TryParse(Comparison, out cmp))
                        return (vl > cmp) ? true : false;
                    else
                        return false;
                case "<":
                    if (int.TryParse(Value, out vl) && int.TryParse(Comparison, out cmp))
                        return (vl < cmp) ? true : false;
                    else
                        return false;
                case ">=":
                    if (int.TryParse(Value, out vl) && int.TryParse(Comparison, out cmp))
                        return (vl >= cmp) ? true : false;
                    else
                        return false;
                case "<=":
                    if (int.TryParse(Value, out vl) && int.TryParse(Comparison, out cmp))
                        return (vl <= cmp) ? true : false;
                    else
                        return false;
                case "<>":
                    return (Value != Comparison) ? true : false;
                default:
                    return false;
            }
        }

        private bool ExistInList(ObjectId obj) {
            foreach (ObjectId id in ToSelect) {
                if (id == obj)
                    return true;
            }
            return false;
        }


        public void SelectFound(Dictionary<string, string> wybory) {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor edt = doc.Editor;
            Transaction tr = db.TransactionManager.StartTransaction();
            ObjectId[] objects = ToSelect.ToArray();

            //Wybór wszystkich elementów spełniających kryteria...
            if (wybory["Action"] == "Select") {
                edt.SetImpliedSelection(objects);
                tr.Commit();
            } else if (wybory["Action"] == "SaveToLayer") {
                using (tr) {
                    BlockTable blkTb = (BlockTable)tr.GetObject(db.BlockTableId, OpenMode.ForRead);
                    BlockTableRecord blkTR = (BlockTableRecord)tr.GetObject(blkTb[BlockTableRecord.ModelSpace], OpenMode.ForWrite);
                    foreach (ObjectId ID in objects) {
                        if (wybory["Modify"] == "Move") {
                            BlockReference br = (BlockReference)tr.GetObject(ID, OpenMode.ForWrite);
                            br.Layer = wybory["Layer"];
                        } else if (wybory["Modify"] == "Copy") {
                            BlockReference br = (BlockReference)tr.GetObject(ID, OpenMode.ForRead);
                            BlockReference NewBr = (BlockReference)br.Clone();
                            NewBr.Layer = wybory["Layer"];
                            blkTR.AppendEntity(NewBr);
                            tr.AddNewlyCreatedDBObject(NewBr, true);
                        }
                    }
                    tr.Commit();
                }
            }
        }
    }
}
