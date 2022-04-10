/*
 * Program do wczytywnia i wybierania na rysunku punktów granicznych
 * charakteruyzują go pełne atrybuty punktów geodezyjnych
 * autor: Damian Zacheja
 * 
 */
using System.Linq;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;

namespace DamianAutoCAD {
    public class MenuGlowne {
        [CommandMethod("PuntyGraniczne")]
        public void WczytajPunktyGraniczne() {
            Editor edt = Application.DocumentManager.MdiActiveDocument.Editor;
            PromptKeywordOptions pko = new PromptKeywordOptions("Opcje punktów granicznych: ");
            pko.Keywords.Add("Selekcja");
            pko.Keywords.Add("Wczytywanie");

            PromptResult pr = edt.GetKeywords(pko);
            string wybor = pr.StringResult;
            switch (wybor) {
                case "Selekcja":
                    OpcjePunktyGraniczneForm form = new OpcjePunktyGraniczneForm();
                    form.Show();
                    break;
                case "Wczytywanie":
                    PunktyGraniczne p = new PunktyGraniczne();
                    p.ImportBlks();
                    WczytajPunktyGraniczneForm pgr = new WczytajPunktyGraniczneForm();
                    pgr.Show();
                    break;
                default:
                    edt.WriteMessage("Nic nie wybrano!");
                    break;
            }

        }

    }


}
