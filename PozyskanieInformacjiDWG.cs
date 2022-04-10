
using System;
using System.Collections.Generic;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;

namespace DamianAutoCAD
{
    public class PozyskanieInformacjiDWG
    {
        /*
         * Metoda zwraca listę warstw w otwartym pliku...
         */
        public List<string> ListaWarstw()
        {
            //Utwórz obiekt listy do zwrócenia...
            List<string> warstwy = new List<string>();
            //Przypisz Dokument, Database i rozpocznij Transaction
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Transaction tr = db.TransactionManager.StartTransaction();
            using (tr)
            {
                //Pobierz listę ID Warstw...
                LayerTable lrTb = tr.GetObject(db.LayerTableId, OpenMode.ForRead) as LayerTable;
                foreach(ObjectId Obj in lrTb)
                {
                    //Pobierz poszczególną warstwę...
                    LayerTableRecord lrTbRec = tr.GetObject(Obj, OpenMode.ForRead) as LayerTableRecord;
                    warstwy.Add(lrTbRec.Name);
                }
            }
            return warstwy;
            
        }

        internal static void AddLayer(string Layer)
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            using (DocumentLock dLoc = doc.LockDocument())
            {
                using (Transaction tr = db.TransactionManager.StartTransaction())
                {
                    LayerTable lt = (LayerTable)tr.GetObject(db.LayerTableId, OpenMode.ForRead);
                    if (!lt.Has(Layer))
                    {
                        LayerTableRecord ltr = new LayerTableRecord();
                        ltr.Name = Layer;
                        lt.UpgradeOpen();
                        ObjectId ltID = lt.Add(ltr);
                        tr.AddNewlyCreatedDBObject(ltr, true);
                    }
                    tr.Commit();
                }
            }
        }

        public static double[] GetPointCoordinates()
        {
            double[] crd = new double[2];
            Document doc = Application.DocumentManager.MdiActiveDocument;
            using (doc.LockDocument())
            {
                Editor edt = doc.Editor;
                PromptPointResult ppr;
                PromptPointOptions ppo = new PromptPointOptions("Wybierz lokalizację działki:");

                ppr = edt.GetPoint(ppo);
                Point3d pt3D = ppr.Value;
                if (ppr.Status == PromptStatus.Cancel) return crd;
                crd[0] = pt3D.X;
                crd[1] = pt3D.Y;
            }
            return crd;
        }

        public static double[] GetRectangle()
        {
            double[] crd = new double[4];
            Document doc = Application.DocumentManager.MdiActiveDocument;
            using (doc.LockDocument())
            {
                Editor edt = doc.Editor;
                PromptPointResult ppr;
                PromptPointOptions ppo = new PromptPointOptions("\nWybierz pierwszy narożnik:");

                ppr = edt.GetPoint(ppo);
                Point3d pt3D = ppr.Value;
                if (ppr.Status == PromptStatus.Cancel) return crd;
                crd[0] = pt3D.X;
                crd[1] = pt3D.Y;
                ppr = edt.GetCorner("\nWybierz drugi narożnik", pt3D);
                Point3d SecPt3D = ppr.Value;
                crd[2] = SecPt3D.X;
                crd[3] = SecPt3D.Y;
            }
            return crd;
            
        }

    }
}
