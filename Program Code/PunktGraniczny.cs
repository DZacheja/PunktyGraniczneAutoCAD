/*
 * Struktura przechowująca infomacje o punkcie granicznym
 * autor: Damian Zacheja
 */
namespace DZacheja_PunktyGraniczne {
    public struct PunktGraniczny {
        public string ID;
        public double X;
        public double Y;
        public string BPP;
        public string STB;
        public string ZRD;
        public string RZG;
        public string plik;
        public string layer;
        public double txtHeight;
        public PunktGraniczny(string iD, double x, double y, string bPP, string sTB, string zRD, string rZG, string Plik, string Layer, double TxtHeight) {
            ID = iD;
            X = x;
            Y = y;
            BPP = bPP;
            STB = sTB;
            ZRD = zRD;
            RZG = rZG;
            plik = Plik;
            layer = Layer;
            txtHeight = TxtHeight;
        }

        public string SetValueByTag(string tag) {
            switch (tag) {
                case "BPP":
                    return BPP;
                case "STB":
                    return STB;
                case "ZRD":
                    return ZRD;
                case "RZG":
                    return RZG;
                case "PLIK":
                    return plik;
                case "ID":
                    return ID;
                default:
                    return "";
            }
        }
    }
}