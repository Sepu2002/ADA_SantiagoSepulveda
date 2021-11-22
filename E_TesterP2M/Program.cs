using System;

namespace E_TesterP2M
{
    class Program
    {
        static void Main(string[] args)
        {
            char cont = 's';
            do
            {
                printElements();
                Info_elementos();
                cont = s_or_n();
            } 
            while (cont == 's' || cont == 'S');
            
        }

        static void printElements() {
            Console.Clear();
            Console.WriteLine("Tabla periódica interactiva");

            for (int i = 0; i <= 180; i++)
            {
                // Dando un salto de linea cada 18 caracteres
                if (i % 18 == 1)
                {
                    Console.WriteLine();
                }

                // if para los pixeles magenta oscuro
                if (i == 1 || i == 32 || i == 33 || i == 34 || i == 51 || i == 52 || i == 70)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (i == 1) Console.Write(" H ");
                if (i == 32) Console.Write(" He");
                if (i == 33) Console.Write(" N ");
                if (i == 34) Console.Write(" O ");
                if (i == 51) Console.Write(" P ");
                if (i == 52) Console.Write(" S ");
                if (i == 70) Console.Write(" Se");

                // if para los pixeles rojos
                if (i == 19 || i == 37 || i == 55 || i == 73 || i == 91 || i == 109)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (i == 19) Console.Write(" Li");
                if (i == 37) Console.Write(" Na");
                if (i == 55) Console.Write(" K ");
                if (i == 73) Console.Write(" Rb");
                if (i == 91) Console.Write(" Cs");
                if (i == 109) Console.Write(" Fr");

                // if para los pixeles cyan
                if (i == 20 || i == 38 || i == 56 || i == 74 || i == 92 || i == 110)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                if (i == 20) Console.Write(" Be");
                if (i == 38) Console.Write(" Mg");
                if (i == 56) Console.Write(" Ca");
                if (i == 74) Console.Write(" Sr");
                if (i == 92) Console.Write(" Ba");
                if (i == 110) Console.Write(" Ra");

                // if para los pixeles amarillos
                if (i == 57 || i == 58 || i == 59 || i == 60 || i == 61 || i == 62 || i == 63 || i == 64 || i == 65
                    || i == 66 || i == 75 || i == 76 || i == 77 || i == 78 || i == 79
                    || i == 80 || i == 81 || i == 82 || i == 83 || i == 84 || i == 94 || i == 95 || i == 96 || i == 97 || i == 98 || i == 99 || i == 100 || i == 101
                    || i == 102 || i == 112 || i == 113 || i == 114 || i == 115 || i == 116 || i == 117 || i == 118 || i == 119 || i == 120)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                if (i == 57) Console.Write(" Sc");
                if (i == 58) Console.Write(" Ti");
                if (i == 59) Console.Write(" V ");
                if (i == 60) Console.Write(" Cr");
                if (i == 61) Console.Write(" Mn");
                if (i == 62) Console.Write(" Fe");
                if (i == 63) Console.Write(" Co");
                if (i == 64) Console.Write(" Ni");
                if (i == 65) Console.Write(" Cu");
                if (i == 66) Console.Write(" Zn");
                if (i == 75) Console.Write(" Y ");
                if (i == 76) Console.Write(" Zr");
                if (i == 77) Console.Write(" Nb");
                if (i == 78) Console.Write(" Mo");
                if (i == 79) Console.Write(" Tc");
                if (i == 80) Console.Write(" Ru");
                if (i == 81) Console.Write(" Rh");
                if (i == 82) Console.Write(" Pd");
                if (i == 83) Console.Write(" Ag");
                if (i == 84) Console.Write(" Cd");
                if (i == 94) Console.Write(" Hf");
                if (i == 95) Console.Write(" Ta");
                if (i == 96) Console.Write(" W ");
                if (i == 97) Console.Write(" Re");
                if (i == 98) Console.Write(" Os");
                if (i == 99) Console.Write(" Ir");
                if (i == 100) Console.Write(" Pt");
                if (i == 101) Console.Write(" Au");
                if (i == 102) Console.Write(" Hg");
                if (i == 112) Console.Write(" Rf");
                if (i == 113) Console.Write(" Db");
                if (i == 114) Console.Write(" Sg");
                if (i == 115) Console.Write(" Bh");
                if (i == 116) Console.Write(" Hs");
                if (i == 117) Console.Write(" Mt");
                if (i == 118) Console.Write(" Ds");
                if (i == 119) Console.Write(" Rg");
                if (i == 120) Console.Write(" Rg");


                // if para los pixeles verde oscuro
                if (i == 49 || i == 67 || i == 85 || i == 86 || i == 103 || i == 104 || i == 105 || i == 121 || i == 122 || i == 123 || i == 124)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (i == 49) Console.Write(" Al");
                if (i == 67) Console.Write(" Ga");
                if (i == 85) Console.Write(" In");
                if (i == 86) Console.Write(" Sn");
                if (i == 103) Console.Write(" Tl");
                if (i == 104) Console.Write(" Pb");
                if (i == 105) Console.Write(" Bi");
                if (i == 121) Console.Write(" Nh");
                if (i == 122) Console.Write(" Fl");
                if (i == 123) Console.Write(" Mc");
                if (i == 124) Console.Write(" Lv");

                // if para los pixeles grises
                if (i == 31 || i == 50 || i == 68 || i == 69 || i == 87 || i == 88 || i == 106)
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (i == 31) Console.Write(" B ");
                if (i == 50) Console.Write(" Si");
                if (i == 68) Console.Write(" Ge");
                if (i == 69) Console.Write(" As");
                if (i == 87) Console.Write(" Sb");
                if (i == 88) Console.Write(" Te");
                if (i == 106) Console.Write(" Po");

                // if para los pixeles magenta 
                if (i == 35 || i == 53 || i == 71 || i == 89 || i == 107 || i == 125)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (i == 35) Console.Write(" F ");
                if (i == 53) Console.Write(" Cl");
                if (i == 71) Console.Write(" Br");
                if (i == 89) Console.Write(" I ");
                if (i == 107) Console.Write(" At");
                if (i == 125) Console.Write(" Ts");

                // if para los pixeles azules 
                if (i == 18 || i == 36 || i == 54 || i == 72 || i == 90 || i == 108 || i == 126)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (i == 18) Console.Write(" He");
                if (i == 36) Console.Write(" Ne");
                if (i == 54) Console.Write(" Ar");
                if (i == 72) Console.Write(" Kr");
                if (i == 90) Console.Write(" Xe");
                if (i == 108) Console.Write(" Rn");
                if (i == 126) Console.Write(" Og");

                // if para los pixeles amarillo oscuro
                if (i == 93 || i == 147 || i == 148 || i == 149 || i == 150 || i == 151 || i == 152
                    || i == 153 || i == 154 || i == 155 || i == 156 || i == 157 || i == 158
                    || i == 159 || i == 160 || i == 161)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (i == 93) Console.Write(" La");
                if (i == 148) Console.Write(" Ce");
                if (i == 149) Console.Write(" Pr");
                if (i == 150) Console.Write(" Nd");
                if (i == 151) Console.Write(" Pm");
                if (i == 152) Console.Write(" Sm");
                if (i == 153) Console.Write(" Eu");
                if (i == 154) Console.Write(" Gd");
                if (i == 155) Console.Write(" Tb");
                if (i == 156) Console.Write(" Dy");
                if (i == 157) Console.Write(" Ho");
                if (i == 158) Console.Write(" Er");
                if (i == 159) Console.Write(" Tm");
                if (i == 160) Console.Write(" Yb");
                if (i == 161) Console.Write(" Lu");
                // if para los pixeles verdes
                if (i == 111 || i == 165 || i == 166 || i == 167 || i == 168 || i == 169
                    || i == 170 || i == 171 || i == 172 || i == 173 || i == 174 || i == 175
                    || i == 176 || i == 177 || i == 178 || i == 179)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (i == 111) Console.Write(" Ac");
                if (i == 166) Console.Write(" Th");
                if (i == 167) Console.Write(" Pa");
                if (i == 168) Console.Write(" U ");
                if (i == 169) Console.Write(" Np");
                if (i == 170) Console.Write(" Pu");
                if (i == 171) Console.Write(" Am");
                if (i == 172) Console.Write(" Cm");
                if (i == 173) Console.Write(" Bk");
                if (i == 174) Console.Write(" Cf");
                if (i == 175) Console.Write(" Es");
                if (i == 176) Console.Write(" Fm");
                if (i == 177) Console.Write(" Md");
                if (i == 178) Console.Write(" No");
                if (i == 179) Console.Write(" Lr");

                // if para los pixeles en blanco
                if (i == 2 || i == 3 || i == 4 || i == 5 || i == 6 || i == 7 || i == 8 || i == 9 || i == 10
                    || i == 11 || i == 12 || i == 13 || i == 14 || i == 15 || i == 16
                    || i == 17 || i == 21 || i == 22 || i == 23 || i == 24 ||
                    i == 25 || i == 26 || i == 27 || i == 28 || i == 29 || i == 30 || i == 39 || i == 40 || i == 41
                    || i == 42 || i == 43 || i == 44 || i == 45 || i == 46 || i == 47 || i == 48
                    || i == 127 || i == 128 || i == 129 || i == 130 || i == 131 || i == 132 || i == 133 || i == 134 || i == 135
                    || i == 136 || i == 137 || i == 138 || i == 139 || i == 140 ||
                    i == 141 || i == 142 || i == 143 || i == 144 || i == 145 || i == 146 || i == 147
                    || i == 162 || i == 163 || i == 164 || i == 165
                    || i == 180)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("   ");
                }


            }
            Console.WriteLine("\n");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" Metales Alkalinos ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" Metales Alkalinotérreos ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(" Metales de trasnsición ");
            Console.WriteLine("\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Metales ");
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Write(" No-Metales ");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write(" Metaloides ");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Write(" Halógenos ");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" Gases Nobles ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(" Lantanidos ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(" Actinidos ");
            Console.WriteLine("\n");
            Console.BackgroundColor = ConsoleColor.Black;

        }
        static char s_or_n()
        {
            Console.WriteLine("Programa exitoso");
            Console.WriteLine("¿Quieres continuar? (s/n) <enter>");
            char output = Convert.ToChar(Console.ReadLine());
            return output;
        }
        static int askint(string mes)
        {
            int output;
            Console.WriteLine("{0}", mes);
            output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
        static void Info_elementos()
        {
            int opcion = askint("Escriba el número atómico del elemento:");
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el HIDRÓGENO");
                    Console.WriteLine("Símbolo: H");
                    Console.WriteLine("Masa atómica: 1.00784 u");
                    Console.WriteLine("Número atómico: 1");
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el HELIO");
                    Console.WriteLine("Símbolo: ");
                    Console.WriteLine("Masa atómica: ");
                    Console.WriteLine("Número atómico: ");
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el LITIO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el BERILIO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el BORO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el CARBONO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 7:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el NITRÓGENO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 8:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el OXÍGENO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 9:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el FLÚOR");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 10:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el NEÓN");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 11:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el SODIO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 12:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el MAGNESIO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 13:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el ALUMINIO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 14:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el SILICIO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 15:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el FÓSFORO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 16:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el AZUFRE");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 17:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el CLORO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 18:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el ARGÓN");
                    Console.WriteLine("TODA LA INFO");
                    break;


                case 19:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el POTASIO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 20:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el CALCIO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 21:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el ESCANDIO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 22:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el TITANIO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 23:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el VANADIO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 24:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el CROMO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 25:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el MANGANESO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 26:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el HIERRO");
                    Console.WriteLine("TODA LA INFO");
                    break;

                case 27:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el COBALTO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 28:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el NÍQUEL");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 29:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el COBRE");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 30:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el ZINC");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 31:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el GALIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 32:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el GERMANIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 33:
                    Console.WriteLine("El elemento seleccionado es el ARSÉNICO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 34:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el SELENIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 35:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el BROMO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 36:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el KRIPTÓN");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 37:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el RUBIDIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 38:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el ESTRONCIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 39:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el ITRIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 40:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el ZIRCONIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 41:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el NIOBIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 42:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el MOLIBDENO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 43:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el TECNECIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 44:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el RUTENIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 45:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el RODIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 46:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el PALADIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 47:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el PLATA");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 48:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el CADMIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 49:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el INDIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 50:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el ESTAÑO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 51:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el ANTIMONIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 52:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el TELURIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 53:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el YODO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 54:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el XENÓN");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 55:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el CESIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 56:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el BARIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 57:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el LANTANO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 58:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el CERIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 59:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el PRASEODIMIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 60:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el NEODIMIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 61:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el PROMETIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 62:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el SAMARIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 63:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el EUROPIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 64:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el GADOLINEO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 65:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el TERBIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 66:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el DISPROSIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 67:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el HOLMIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 68:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el ERBIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 69:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el TULIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 70:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el ITERBIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 71:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el LITECIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 72:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el HAFNIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 73:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el TANTALIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 74:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el VOLFRAMIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 75:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el RENIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 76:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el OSMIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 77:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el IRIDIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 78:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el PLATINO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 79:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el ORO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 80:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el MERCURIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 81:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el TALIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 82:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el PLOMO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 83:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el BISMUTO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 84:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el POLONIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 85:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el ASTATO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 86:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el RADÓN");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 87:
                    Console.WriteLine("El elemento seleccionado es el FRANCIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 88:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el RADIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 89:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el ACTINIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 90:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el TORIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 91:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el PROTACTINIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 92:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el URANIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 93:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el NEPTUNO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 94:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el PLUTONIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 95:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el AMERICIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 96:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el CURIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 97:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el BERKELIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 98:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el CALIFORNIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 99:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el EINSTENIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 100:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el FERMIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 101:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el MENDELEVIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 102:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el NOBELIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 103:
                    Console.WriteLine("El elemento seleccionado es el LAURENCIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 104:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el RUTHERFORDIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 105:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el DUBNIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 106:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el SEABORGIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 107:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el BOHRIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 108:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el HASSIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 109:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el MEITNERIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 110:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el DARMSTADTIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 111:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el ROENTGENIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 112:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el COPERNICIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 113:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el NIHONIUM");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 114:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el FLEROVIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 115:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el MOSCOVIUM");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 116:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el LIVERMORIO");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 117:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el TENESSINE");
                    Console.WriteLine("TODA LA INFO");
                    break;
                case 118:
                    Console.Clear();
                    Console.WriteLine("El elemento seleccionado es el ORGANESSON");
                    Console.WriteLine("TODA LA INFO");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("No seleccionaste ninguna opción en la tabla");
                    Console.WriteLine("Vuelve a intentarlo");
                    break;

            }
        }
        }
}
