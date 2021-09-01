using System;

namespace E_switchUltimoDigito
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, uni, dec, cent;
            Console.WriteLine("Programa que obtiene el último dígito y lo presenta en palabras y en número:");

            Console.WriteLine("Escribe un número: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);

            uni = num % 10;
            dec = (num / 10) % 10;
            cent = (num / 100) % 10;


            switch (uni)
            {

                case 0:
                    Console.WriteLine("        CCCCCCCCCCCCCEEEEEEEEEEEEEEEEEEEEEERRRRRRRRRRRRRRRRR        OOOOOOOOO");
                    Console.WriteLine("     CCC::::::::::::CE::::::::::::::::::::ER::::::::::::::::R     OO:::::::::OO");
                    Console.WriteLine("   CC:::::::::::::::CE::::::::::::::::::::ER::::::RRRRRR:::::R  OO:::::::::::::OO");
                    Console.WriteLine("  C:::::CCCCCCCC::::CEE::::::EEEEEEEEE::::ERR:::::R     R:::::RO:::::::OOO:::::::O");
                    Console.WriteLine(" C:::::C       CCCCCC  E:::::E       EEEEEE  R::::R     R:::::RO::::::O   O::::::O");
                    Console.WriteLine("C:::::C                E:::::E               R::::R     R:::::RO:::::O     O:::::O");
                    Console.WriteLine("C:::::C                E::::::EEEEEEEEEE     R::::RRRRRR:::::R O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                E:::::::::::::::E     R:::::::::::::RR  O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                E:::::::::::::::E     R::::RRRRRR:::::R O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                E::::::EEEEEEEEEE     R::::R     R:::::RO:::::O     O:::::O");
                    Console.WriteLine("C:::::C                E:::::E               R::::R     R:::::RO:::::O     O:::::O");
                    Console.WriteLine(" C:::::C       CCCCCC  E:::::E       EEEEEE  R::::R     R:::::RO::::::O   O::::::O");
                    Console.WriteLine("  C:::::CCCCCCCC::::CEE::::::EEEEEEEE:::::ERR:::::R     R:::::RO:::::::OOO:::::::O");
                    Console.WriteLine("   CC:::::::::::::::CE::::::::::::::::::::ER::::::R     R:::::R OO:::::::::::::OO");
                    Console.WriteLine("     CCC::::::::::::CE::::::::::::::::::::ER::::::R     R:::::R   OO:::::::::OO");
                    Console.WriteLine("        CCCCCCCCCCCCCEEEEEEEEEEEEEEEEEEEEEERRRRRRRR     RRRRRRR     OOOOOOOOO");
                    Console.WriteLine("Unidades");
                    break;

                case 1:
                    Console.WriteLine("UUUUUUUU     UUUUUUUUNNNNNNNN        NNNNNNNN     OOOOOOOOO ");
                    Console.WriteLine("U::::::U     U::::::UN:::::::N       N::::::N   OO:::::::::OO");
                    Console.WriteLine("U::::::U     U::::::UN::::::::N      N::::::N OO:::::::::::::OO");
                    Console.WriteLine("UU:::::U     U:::::UUN:::::::::N     N::::::NO:::::::OOO:::::::O");
                    Console.WriteLine(" U:::::U     U:::::U N::::::::::N    N::::::NO::::::O   O::::::O");
                    Console.WriteLine(" U:::::D     D:::::U N:::::::::::N   N::::::NO:::::O     O:::::O");
                    Console.WriteLine(" U:::::D     D:::::U N:::::::N::::N  N::::::NO:::::O     O:::::O");
                    Console.WriteLine(" U:::::D     D:::::U N::::::N N::::N N::::::NO:::::O     O:::::O");
                    Console.WriteLine(" U:::::D     D:::::U N::::::N  N::::N:::::::NO:::::O     O:::::O");
                    Console.WriteLine(" U:::::D     D:::::U N::::::N   N:::::::::::NO:::::O     O:::::O");
                    Console.WriteLine(" U:::::D     D:::::U N::::::N    N::::::::::NO:::::O     O:::::O");
                    Console.WriteLine(" U::::::U   U::::::U N::::::N     N:::::::::NO::::::O   O::::::O");
                    Console.WriteLine(" U:::::::UUU:::::::U N::::::N      N::::::::NO:::::::OOO:::::::O");
                    Console.WriteLine("  UU:::::::::::::UU  N::::::N       N:::::::N OO:::::::::::::OO ");
                    Console.WriteLine("    UU:::::::::UU    N::::::N        N::::::N   OO:::::::::OO");
                    Console.WriteLine("      UUUUUUUUU      NNNNNNNN         NNNNNNN     OOOOOOOOO");
                    Console.WriteLine("Unidades");
                    break;

                case 2:
                    Console.WriteLine("DDDDDDDDDDDDD             OOOOOOOOO        SSSSSSSSSSSSSSS");
                    Console.WriteLine("D::::::::::::DDD        OO:::::::::OO    SS:::::::::::::::S");
                    Console.WriteLine("D:::::::::::::::DD    OO:::::::::::::OO S:::::SSSSSS::::::S");
                    Console.WriteLine("DDD:::::DDDDD:::::D  O:::::::OOO:::::::OS:::::S     SSSSSSS");
                    Console.WriteLine("  D:::::D    D:::::D O::::::O   O::::::OS:::::S ");
                    Console.WriteLine("  D:::::D     D:::::DO:::::O     O:::::OS:::::S");
                    Console.WriteLine("  D:::::D     D:::::DO:::::O     O:::::O S::::SSSS");
                    Console.WriteLine("  D:::::D     D:::::DO:::::O     O:::::O  SS::::::SSSSS");
                    Console.WriteLine("  D:::::D     D:::::DO:::::O     O:::::O    SSS::::::::SS");
                    Console.WriteLine("  D:::::D     D:::::DO:::::O     O:::::O       SSSSSS::::S");
                    Console.WriteLine("  D:::::D     D:::::DO:::::O     O:::::O            S:::::S");
                    Console.WriteLine("  D:::::D    D:::::D O::::::O   O::::::O            S:::::S");
                    Console.WriteLine("DDD:::::DDDDD:::::D  O:::::::OOO:::::::OSSSSSSS     S:::::S");
                    Console.WriteLine("D:::::::::::::::DD    OO:::::::::::::OO S::::::SSSSSS:::::S");
                    Console.WriteLine("D::::::::::::DDD        OO:::::::::OO   S:::::::::::::::SS");
                    Console.WriteLine("DDDDDDDDDDDDD             OOOOOOOOO      SSSSSSSSSSSSSSS");
                    Console.WriteLine("Unidades");
                    break;

                case 3:
                    Console.WriteLine("TTTTTTTTTTTTTTTTTTTTTTTRRRRRRRRRRRRRRRRR   EEEEEEEEEEEEEEEEEEEEEE   SSSSSSSSSSSSSSS");
                    Console.WriteLine("T:::::::::::::::::::::TR::::::::::::::::R  E::::::::::::::::::::E SS:::::::::::::::S");
                    Console.WriteLine("T:::::::::::::::::::::TR::::::RRRRRR:::::R E::::::::::::::::::::ES:::::SSSSSS::::::S");
                    Console.WriteLine("T:::::TT:::::::TT:::::TRR:::::R     R:::::REE::::::EEEEEEEEE::::ES:::::S     SSSSSSS");
                    Console.WriteLine("TTTTTT  T:::::T  TTTTTT  R::::R     R:::::R  E:::::E       EEEEEES:::::S");
                    Console.WriteLine("        T:::::T          R::::R     R:::::R  E:::::E             S:::::S");
                    Console.WriteLine("        T:::::T          R::::RRRRRR:::::R   E::::::EEEEEEEEEE    S::::SSSS");
                    Console.WriteLine("        T:::::T          R:::::::::::::RR    E:::::::::::::::E     SS::::::SSSSS");
                    Console.WriteLine("        T:::::T          R::::RRRRRR:::::R   E:::::::::::::::E       SSS::::::::SS");
                    Console.WriteLine("        T:::::T          R::::R     R:::::R  E::::::EEEEEEEEEE          SSSSSS::::S");
                    Console.WriteLine("        T:::::T          R::::R     R:::::R  E:::::E                         S:::::S");
                    Console.WriteLine("        T:::::T          R::::R     R:::::R  E:::::E       EEEEEE            S:::::S");
                    Console.WriteLine("      TT:::::::TT      RR:::::R     R:::::REE::::::EEEEEEEE:::::ESSSSSSS     S:::::S");
                    Console.WriteLine("      T:::::::::T      R::::::R     R:::::RE::::::::::::::::::::ES::::::SSSSSS:::::S");
                    Console.WriteLine("      T:::::::::T      R::::::R     R:::::RE::::::::::::::::::::ES:::::::::::::::SS");
                    Console.WriteLine("      TTTTTTTTTTT      RRRRRRRR     RRRRRRREEEEEEEEEEEEEEEEEEEEEE SSSSSSSSSSSSSSS");
                    Console.WriteLine("Unidades");
                    break;

                case 4:
                    Console.WriteLine("        CCCCCCCCCCCCCUUUUUUUU     UUUUUUUU           AAA         TTTTTTTTTTTTTTTTTTTTTTTRRRRRRRRRRRRRRRRR        OOOOOOOOO");
                    Console.WriteLine("     CCC::::::::::::CU::::::U     U::::::U          A:::A        T:::::::::::::::::::::TR::::::::::::::::R     OO:::::::::OO");
                    Console.WriteLine("   CC:::::::::::::::CU::::::U     U::::::U         A:::::A       T:::::::::::::::::::::TR::::::RRRRRR:::::R  OO:::::::::::::OO");
                    Console.WriteLine("  C:::::CCCCCCCC::::CUU:::::U     U:::::UU        A:::::::A      T:::::TT:::::::TT:::::TRR:::::R     R:::::RO:::::::OOO:::::::O");
                    Console.WriteLine("  C:::::CCCCCCCC::::CUU:::::U     U:::::UU        A:::::::A      T:::::TT:::::::TT:::::TRR:::::R     R:::::RO:::::::OOO:::::::O");
                    Console.WriteLine(" C:::::C       CCCCCC U:::::U     U:::::U        A:::::::::A     TTTTTT  T:::::T  TTTTTT  R::::R     R:::::RO::::::O   O::::::O");
                    Console.WriteLine("C:::::C               U:::::D     D:::::U       A:::::A:::::A            T:::::T          R::::R     R:::::RO:::::O     O:::::O");
                    Console.WriteLine("C:::::C               U:::::D     D:::::U      A:::::A A:::::A           T:::::T          R::::RRRRRR:::::R O:::::O     O:::::O");
                    Console.WriteLine("C:::::C               U:::::D     D:::::U     A:::::A   A:::::A          T:::::T          R:::::::::::::RR  O:::::O     O:::::O");
                    Console.WriteLine("C:::::C               U:::::D     D:::::U    A:::::A     A:::::A         T:::::T          R::::RRRRRR:::::R O:::::O     O:::::O");
                    Console.WriteLine("C:::::C               U:::::D     D:::::U   A:::::AAAAAAAAA:::::A        T:::::T          R::::R     R:::::RO:::::O     O:::::O");
                    Console.WriteLine("C:::::C               U:::::D     D:::::U  A:::::::::::::::::::::A       T:::::T          R::::R     R:::::RO:::::O     O:::::O");
                    Console.WriteLine(" C:::::C       CCCCCC U::::::U   U::::::U A:::::AAAAAAAAAAAAA:::::A      T:::::T          R::::R     R:::::RO::::::O   O::::::O");
                    Console.WriteLine("  C:::::CCCCCCCC::::C U:::::::UUU:::::::UA:::::A             A:::::A   TT:::::::TT      RR:::::R     R:::::RO:::::::OOO:::::::O");
                    Console.WriteLine("   CC:::::::::::::::C  UU:::::::::::::UUA:::::A               A:::::A  T:::::::::T      R::::::R     R:::::R OO:::::::::::::OO ");
                    Console.WriteLine("     CCC::::::::::::C    UU:::::::::UU A:::::A                 A:::::A T:::::::::T      R::::::R     R:::::R   OO:::::::::OO");
                    Console.WriteLine("        CCCCCCCCCCCCC      UUUUUUUUU  AAAAAAA                   AAAAAAATTTTTTTTTTT      RRRRRRRR     RRRRRRR     OOOOOOOOO");
                    Console.WriteLine("Unidades");
                    break;

                case 5:
                    Console.WriteLine("        CCCCCCCCCCCCCIIIIIIIIIINNNNNNNN        NNNNNNNN        CCCCCCCCCCCCC     OOOOOOOOO");
                    Console.WriteLine("     CCC::::::::::::CI::::::::IN:::::::N       N::::::N     CCC::::::::::::C   OO:::::::::OO");
                    Console.WriteLine("   CC:::::::::::::::CI::::::::IN::::::::N      N::::::N   CC:::::::::::::::C OO:::::::::::::OO");
                    Console.WriteLine("  C:::::CCCCCCCC::::CII::::::IIN:::::::::N     N::::::N  C:::::CCCCCCCC::::CO:::::::OOO:::::::O");
                    Console.WriteLine(" C:::::C       CCCCCC  I::::I  N::::::::::N    N::::::N C:::::C       CCCCCCO::::::O   O::::::O");
                    Console.WriteLine("C:::::C                I::::I  N:::::::::::N   N::::::NC:::::C              O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                I::::I  N:::::::N::::N  N::::::NC:::::C              O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                I::::I  N::::::N N::::N N::::::NC:::::C              O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                I::::I  N::::::N  N::::N:::::::NC:::::C              O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                I::::I  N::::::N   N:::::::::::NC:::::C              O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                I::::I  N::::::N    N::::::::::NC:::::C              O:::::O     O:::::O");
                    Console.WriteLine(" C:::::C       CCCCCC  I::::I  N::::::N     N:::::::::N C:::::C       CCCCCCO::::::O   O::::::O");
                    Console.WriteLine("  C:::::CCCCCCCC::::CII::::::IIN::::::N      N::::::::N  C:::::CCCCCCCC::::CO:::::::OOO:::::::O");
                    Console.WriteLine("   CC:::::::::::::::CI::::::::IN::::::N       N:::::::N   CC:::::::::::::::C OO:::::::::::::OO");
                    Console.WriteLine("     CCC::::::::::::CI::::::::IN::::::N        N::::::N     CCC::::::::::::C   OO:::::::::OO");
                    Console.WriteLine("        CCCCCCCCCCCCCIIIIIIIIIINNNNNNNN         NNNNNNN        CCCCCCCCCCCCC     OOOOOOOOO ");
                    Console.WriteLine("Unidades");
                    break;

                case 6:
                    Console.WriteLine("   SSSSSSSSSSSSSSS EEEEEEEEEEEEEEEEEEEEEEIIIIIIIIII   SSSSSSSSSSSSSSS");
                    Console.WriteLine(" SS:::::::::::::::SE::::::::::::::::::::EI::::::::I SS:::::::::::::::S");
                    Console.WriteLine("S:::::SSSSSS::::::SE::::::::::::::::::::EI::::::::IS:::::SSSSSS::::::S");
                    Console.WriteLine("S:::::S     SSSSSSSEE::::::EEEEEEEEE::::EII::::::IIS:::::S     SSSSSSS");
                    Console.WriteLine("S:::::S              E:::::E       EEEEEE  I::::I  S:::::S");
                    Console.WriteLine("S:::::S              E:::::E               I::::I  S:::::S");
                    Console.WriteLine(" S::::SSSS           E::::::EEEEEEEEEE     I::::I   S::::SSSS");
                    Console.WriteLine("  SS::::::SSSSS      E:::::::::::::::E     I::::I    SS::::::SSSSS");
                    Console.WriteLine("    SSS::::::::SS    E:::::::::::::::E     I::::I      SSS::::::::SS");
                    Console.WriteLine("       SSSSSS::::S   E::::::EEEEEEEEEE     I::::I         SSSSSS::::S");
                    Console.WriteLine("            S:::::S  E:::::E               I::::I              S:::::S");
                    Console.WriteLine("            S:::::S  E:::::E       EEEEEE  I::::I              S:::::S");
                    Console.WriteLine("SSSSSSS     S:::::SEE::::::EEEEEEEE:::::EII::::::IISSSSSSS     S:::::S");
                    Console.WriteLine("S::::::SSSSSS:::::SE::::::::::::::::::::EI::::::::IS::::::SSSSSS:::::S");
                    Console.WriteLine("S:::::::::::::::SS E::::::::::::::::::::EI::::::::IS:::::::::::::::SS ");
                    Console.WriteLine(" SSSSSSSSSSSSSSS   EEEEEEEEEEEEEEEEEEEEEEIIIIIIIIII SSSSSSSSSSSSSSS ");
                    Console.WriteLine("Unidades");
                    break;

                case 7:
                    Console.WriteLine("   SSSSSSSSSSSSSSS IIIIIIIIIIEEEEEEEEEEEEEEEEEEEEEETTTTTTTTTTTTTTTTTTTTTTTEEEEEEEEEEEEEEEEEEEEEE");
                    Console.WriteLine(" SS:::::::::::::::SI::::::::IE::::::::::::::::::::ET:::::::::::::::::::::TE::::::::::::::::::::E");
                    Console.WriteLine("S:::::SSSSSS::::::SI::::::::IE::::::::::::::::::::ET:::::::::::::::::::::TE::::::::::::::::::::E");
                    Console.WriteLine("S:::::S     SSSSSSSII::::::IIEE::::::EEEEEEEEE::::ET:::::TT:::::::TT:::::TEE::::::EEEEEEEEE::::E");
                    Console.WriteLine("S:::::S              I::::I    E:::::E       EEEEEETTTTTT  T:::::T  TTTTTT  E:::::E       EEEEEE");
                    Console.WriteLine("S:::::S              I::::I    E:::::E                     T:::::T          E:::::E");
                    Console.WriteLine(" S::::SSSS           I::::I    E::::::EEEEEEEEEE           T:::::T          E::::::EEEEEEEEEE");
                    Console.WriteLine("  SS::::::SSSSS      I::::I    E:::::::::::::::E           T:::::T          E:::::::::::::::E");
                    Console.WriteLine("    SSS::::::::SS    I::::I    E:::::::::::::::E           T:::::T          E:::::::::::::::E");
                    Console.WriteLine("       SSSSSS::::S   I::::I    E::::::EEEEEEEEEE           T:::::T          E::::::EEEEEEEEEE ");
                    Console.WriteLine("            S:::::S  I::::I    E:::::E                     T:::::T          E:::::E");
                    Console.WriteLine("            S:::::S  I::::I    E:::::E       EEEEEE        T:::::T          E:::::E       EEEEEE");
                    Console.WriteLine("SSSSSSS     S:::::SII::::::IIEE::::::EEEEEEEE:::::E      TT:::::::TT      EE::::::EEEEEEEE:::::E");
                    Console.WriteLine("S::::::SSSSSS:::::SI::::::::IE::::::::::::::::::::E      T:::::::::T      E::::::::::::::::::::E");
                    Console.WriteLine("S:::::::::::::::SS I::::::::IE::::::::::::::::::::E      T:::::::::T      E::::::::::::::::::::E");
                    Console.WriteLine(" SSSSSSSSSSSSSSS   IIIIIIIIIIEEEEEEEEEEEEEEEEEEEEEE      TTTTTTTTTTT      EEEEEEEEEEEEEEEEEEEEEE");
                    Console.WriteLine("Unidades");
                    break;

                case 8:
                    Console.WriteLine("     OOOOOOOOO             CCCCCCCCCCCCCHHHHHHHHH     HHHHHHHHH     OOOOOOOOO");
                    Console.WriteLine("   OO:::::::::OO        CCC::::::::::::CH:::::::H     H:::::::H   OO:::::::::OO");
                    Console.WriteLine(" OO:::::::::::::OO    CC:::::::::::::::CH:::::::H     H:::::::H OO:::::::::::::OO");
                    Console.WriteLine("O:::::::OOO:::::::O  C:::::CCCCCCCC::::CHH::::::H     H::::::HHO:::::::OOO:::::::O");
                    Console.WriteLine("O::::::O   O::::::O C:::::C       CCCCCC  H:::::H     H:::::H  O::::::O   O::::::O");
                    Console.WriteLine("O:::::O     O:::::OC:::::C                H:::::H     H:::::H  O:::::O     O:::::O");
                    Console.WriteLine("O:::::O     O:::::OC:::::C                H::::::HHHHH::::::H  O:::::O     O:::::O");
                    Console.WriteLine("O:::::O     O:::::OC:::::C                H:::::::::::::::::H  O:::::O     O:::::O");
                    Console.WriteLine("O:::::O     O:::::OC:::::C                H:::::::::::::::::H  O:::::O     O:::::O");
                    Console.WriteLine("O:::::O     O:::::OC:::::C                H::::::HHHHH::::::H  O:::::O     O:::::O");
                    Console.WriteLine("O:::::O     O:::::OC:::::C                H:::::H     H:::::H  O:::::O     O:::::O");
                    Console.WriteLine("O::::::O   O::::::O C:::::C       CCCCCC  H:::::H     H:::::H  O::::::O   O::::::O");
                    Console.WriteLine("O:::::::OOO:::::::O  C:::::CCCCCCCC::::CHH::::::H     H::::::HHO:::::::OOO:::::::O");
                    Console.WriteLine(" OO:::::::::::::OO    CC:::::::::::::::CH:::::::H     H:::::::H OO:::::::::::::OO");
                    Console.WriteLine("   OO:::::::::OO        CCC::::::::::::CH:::::::H     H:::::::H   OO:::::::::OO");
                    Console.WriteLine("     OOOOOOOOO             CCCCCCCCCCCCCHHHHHHHHH     HHHHHHHHH     OOOOOOOOO");
                    Console.WriteLine("Unidades");
                    break;

                case 9:
                    Console.WriteLine("NNNNNNNN        NNNNNNNNUUUUUUUU     UUUUUUUUEEEEEEEEEEEEEEEEEEEEEEVVVVVVVV           VVVVVVVVEEEEEEEEEEEEEEEEEEEEEE");
                    Console.WriteLine("N:::::::N       N::::::NU::::::U     U::::::UE::::::::::::::::::::EV::::::V           V::::::VE::::::::::::::::::::E");
                    Console.WriteLine("N::::::::N      N::::::NU::::::U     U::::::UE::::::::::::::::::::EV::::::V           V::::::VE::::::::::::::::::::E");
                    Console.WriteLine("N:::::::::N     N::::::NUU:::::U     U:::::UUEE::::::EEEEEEEEE::::EV::::::V           V::::::VEE::::::EEEEEEEEE::::E");
                    Console.WriteLine("N::::::::::N    N::::::N U:::::U     U:::::U   E:::::E       EEEEEE V:::::V           V:::::V   E:::::E       EEEEEE");
                    Console.WriteLine("N:::::::::::N   N::::::N U:::::D     D:::::U   E:::::E               V:::::V         V:::::V    E:::::E");
                    Console.WriteLine("N:::::::N::::N  N::::::N U:::::D     D:::::U   E::::::EEEEEEEEEE      V:::::V       V:::::V     E::::::EEEEEEEEEE");
                    Console.WriteLine("N::::::N N::::N N::::::N U:::::D     D:::::U   E:::::::::::::::E       V:::::V     V:::::V      E:::::::::::::::E");
                    Console.WriteLine("N::::::N  N::::N:::::::N U:::::D     D:::::U   E:::::::::::::::E        V:::::V   V:::::V       E:::::::::::::::E");
                    Console.WriteLine("N::::::N   N:::::::::::N U:::::D     D:::::U   E::::::EEEEEEEEEE         V:::::V V:::::V        E::::::EEEEEEEEEE");
                    Console.WriteLine("N::::::N    N::::::::::N U:::::D     D:::::U   E:::::E                    V:::::V:::::V         E:::::E");
                    Console.WriteLine("N::::::N     N:::::::::N U::::::U   U::::::U   E:::::E       EEEEEE        V:::::::::V          E:::::E       EEEEEE");
                    Console.WriteLine("N::::::N      N::::::::N U:::::::UUU:::::::U EE::::::EEEEEEEE:::::E         V:::::::V         EE::::::EEEEEEEE:::::E");
                    Console.WriteLine("N::::::N       N:::::::N  UU:::::::::::::UU  E::::::::::::::::::::E          V:::::V          E::::::::::::::::::::E");
                    Console.WriteLine("N::::::N        N::::::N    UU:::::::::UU    E::::::::::::::::::::E           V:::V           E::::::::::::::::::::E");
                    Console.WriteLine("NNNNNNNN         NNNNNNN      UUUUUUUUU      EEEEEEEEEEEEEEEEEEEEEE            VVV            EEEEEEEEEEEEEEEEEEEEEE");
                    Console.WriteLine("Unidades");
                    break;

            }
            switch (dec) 
            {

                case 0:
                    Console.WriteLine("        CCCCCCCCCCCCCEEEEEEEEEEEEEEEEEEEEEERRRRRRRRRRRRRRRRR        OOOOOOOOO");
                    Console.WriteLine("     CCC::::::::::::CE::::::::::::::::::::ER::::::::::::::::R     OO:::::::::OO");
                    Console.WriteLine("   CC:::::::::::::::CE::::::::::::::::::::ER::::::RRRRRR:::::R  OO:::::::::::::OO");
                    Console.WriteLine("  C:::::CCCCCCCC::::CEE::::::EEEEEEEEE::::ERR:::::R     R:::::RO:::::::OOO:::::::O");
                    Console.WriteLine(" C:::::C       CCCCCC  E:::::E       EEEEEE  R::::R     R:::::RO::::::O   O::::::O");
                    Console.WriteLine("C:::::C                E:::::E               R::::R     R:::::RO:::::O     O:::::O");
                    Console.WriteLine("C:::::C                E::::::EEEEEEEEEE     R::::RRRRRR:::::R O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                E:::::::::::::::E     R:::::::::::::RR  O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                E:::::::::::::::E     R::::RRRRRR:::::R O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                E::::::EEEEEEEEEE     R::::R     R:::::RO:::::O     O:::::O");
                    Console.WriteLine("C:::::C                E:::::E               R::::R     R:::::RO:::::O     O:::::O");
                    Console.WriteLine(" C:::::C       CCCCCC  E:::::E       EEEEEE  R::::R     R:::::RO::::::O   O::::::O");
                    Console.WriteLine("  C:::::CCCCCCCC::::CEE::::::EEEEEEEE:::::ERR:::::R     R:::::RO:::::::OOO:::::::O");
                    Console.WriteLine("   CC:::::::::::::::CE::::::::::::::::::::ER::::::R     R:::::R OO:::::::::::::OO");
                    Console.WriteLine("     CCC::::::::::::CE::::::::::::::::::::ER::::::R     R:::::R   OO:::::::::OO");
                    Console.WriteLine("        CCCCCCCCCCCCCEEEEEEEEEEEEEEEEEEEEEERRRRRRRR     RRRRRRR     OOOOOOOOO");
                    Console.WriteLine("Decenas");
                    break;

                case 1:
                    Console.WriteLine("UUUUUUUU     UUUUUUUUNNNNNNNN        NNNNNNNN     OOOOOOOOO ");
                    Console.WriteLine("U::::::U     U::::::UN:::::::N       N::::::N   OO:::::::::OO");
                    Console.WriteLine("U::::::U     U::::::UN::::::::N      N::::::N OO:::::::::::::OO");
                    Console.WriteLine("UU:::::U     U:::::UUN:::::::::N     N::::::NO:::::::OOO:::::::O");
                    Console.WriteLine(" U:::::U     U:::::U N::::::::::N    N::::::NO::::::O   O::::::O");
                    Console.WriteLine(" U:::::D     D:::::U N:::::::::::N   N::::::NO:::::O     O:::::O");
                    Console.WriteLine(" U:::::D     D:::::U N:::::::N::::N  N::::::NO:::::O     O:::::O");
                    Console.WriteLine(" U:::::D     D:::::U N::::::N N::::N N::::::NO:::::O     O:::::O");
                    Console.WriteLine(" U:::::D     D:::::U N::::::N  N::::N:::::::NO:::::O     O:::::O");
                    Console.WriteLine(" U:::::D     D:::::U N::::::N   N:::::::::::NO:::::O     O:::::O");
                    Console.WriteLine(" U:::::D     D:::::U N::::::N    N::::::::::NO:::::O     O:::::O");
                    Console.WriteLine(" U::::::U   U::::::U N::::::N     N:::::::::NO::::::O   O::::::O");
                    Console.WriteLine(" U:::::::UUU:::::::U N::::::N      N::::::::NO:::::::OOO:::::::O");
                    Console.WriteLine("  UU:::::::::::::UU  N::::::N       N:::::::N OO:::::::::::::OO ");
                    Console.WriteLine("    UU:::::::::UU    N::::::N        N::::::N   OO:::::::::OO");
                    Console.WriteLine("      UUUUUUUUU      NNNNNNNN         NNNNNNN     OOOOOOOOO");
                    Console.WriteLine("Decenas");
                    break;

                case 2:
                    Console.WriteLine("DDDDDDDDDDDDD             OOOOOOOOO        SSSSSSSSSSSSSSS");
                    Console.WriteLine("D::::::::::::DDD        OO:::::::::OO    SS:::::::::::::::S");
                    Console.WriteLine("D:::::::::::::::DD    OO:::::::::::::OO S:::::SSSSSS::::::S");
                    Console.WriteLine("DDD:::::DDDDD:::::D  O:::::::OOO:::::::OS:::::S     SSSSSSS");
                    Console.WriteLine("  D:::::D    D:::::D O::::::O   O::::::OS:::::S ");
                    Console.WriteLine("  D:::::D     D:::::DO:::::O     O:::::OS:::::S");
                    Console.WriteLine("  D:::::D     D:::::DO:::::O     O:::::O S::::SSSS");
                    Console.WriteLine("  D:::::D     D:::::DO:::::O     O:::::O  SS::::::SSSSS");
                    Console.WriteLine("  D:::::D     D:::::DO:::::O     O:::::O    SSS::::::::SS");
                    Console.WriteLine("  D:::::D     D:::::DO:::::O     O:::::O       SSSSSS::::S");
                    Console.WriteLine("  D:::::D     D:::::DO:::::O     O:::::O            S:::::S");
                    Console.WriteLine("  D:::::D    D:::::D O::::::O   O::::::O            S:::::S");
                    Console.WriteLine("DDD:::::DDDDD:::::D  O:::::::OOO:::::::OSSSSSSS     S:::::S");
                    Console.WriteLine("D:::::::::::::::DD    OO:::::::::::::OO S::::::SSSSSS:::::S");
                    Console.WriteLine("D::::::::::::DDD        OO:::::::::OO   S:::::::::::::::SS");
                    Console.WriteLine("DDDDDDDDDDDDD             OOOOOOOOO      SSSSSSSSSSSSSSS");
                    Console.WriteLine("Decenas");
                    break;

                case 3:
                    Console.WriteLine("TTTTTTTTTTTTTTTTTTTTTTTRRRRRRRRRRRRRRRRR   EEEEEEEEEEEEEEEEEEEEEE   SSSSSSSSSSSSSSS");
                    Console.WriteLine("T:::::::::::::::::::::TR::::::::::::::::R  E::::::::::::::::::::E SS:::::::::::::::S");
                    Console.WriteLine("T:::::::::::::::::::::TR::::::RRRRRR:::::R E::::::::::::::::::::ES:::::SSSSSS::::::S");
                    Console.WriteLine("T:::::TT:::::::TT:::::TRR:::::R     R:::::REE::::::EEEEEEEEE::::ES:::::S     SSSSSSS");
                    Console.WriteLine("TTTTTT  T:::::T  TTTTTT  R::::R     R:::::R  E:::::E       EEEEEES:::::S");
                    Console.WriteLine("        T:::::T          R::::R     R:::::R  E:::::E             S:::::S");
                    Console.WriteLine("        T:::::T          R::::RRRRRR:::::R   E::::::EEEEEEEEEE    S::::SSSS");
                    Console.WriteLine("        T:::::T          R:::::::::::::RR    E:::::::::::::::E     SS::::::SSSSS");
                    Console.WriteLine("        T:::::T          R::::RRRRRR:::::R   E:::::::::::::::E       SSS::::::::SS");
                    Console.WriteLine("        T:::::T          R::::R     R:::::R  E::::::EEEEEEEEEE          SSSSSS::::S");
                    Console.WriteLine("        T:::::T          R::::R     R:::::R  E:::::E                         S:::::S");
                    Console.WriteLine("        T:::::T          R::::R     R:::::R  E:::::E       EEEEEE            S:::::S");
                    Console.WriteLine("      TT:::::::TT      RR:::::R     R:::::REE::::::EEEEEEEE:::::ESSSSSSS     S:::::S");
                    Console.WriteLine("      T:::::::::T      R::::::R     R:::::RE::::::::::::::::::::ES::::::SSSSSS:::::S");
                    Console.WriteLine("      T:::::::::T      R::::::R     R:::::RE::::::::::::::::::::ES:::::::::::::::SS");
                    Console.WriteLine("      TTTTTTTTTTT      RRRRRRRR     RRRRRRREEEEEEEEEEEEEEEEEEEEEE SSSSSSSSSSSSSSS");
                    Console.WriteLine("Decenas");
                    break;

                case 4:
                    Console.WriteLine("        CCCCCCCCCCCCCUUUUUUUU     UUUUUUUU           AAA         TTTTTTTTTTTTTTTTTTTTTTTRRRRRRRRRRRRRRRRR        OOOOOOOOO");
                    Console.WriteLine("     CCC::::::::::::CU::::::U     U::::::U          A:::A        T:::::::::::::::::::::TR::::::::::::::::R     OO:::::::::OO");
                    Console.WriteLine("   CC:::::::::::::::CU::::::U     U::::::U         A:::::A       T:::::::::::::::::::::TR::::::RRRRRR:::::R  OO:::::::::::::OO");
                    Console.WriteLine("  C:::::CCCCCCCC::::CUU:::::U     U:::::UU        A:::::::A      T:::::TT:::::::TT:::::TRR:::::R     R:::::RO:::::::OOO:::::::O");
                    Console.WriteLine("  C:::::CCCCCCCC::::CUU:::::U     U:::::UU        A:::::::A      T:::::TT:::::::TT:::::TRR:::::R     R:::::RO:::::::OOO:::::::O");
                    Console.WriteLine(" C:::::C       CCCCCC U:::::U     U:::::U        A:::::::::A     TTTTTT  T:::::T  TTTTTT  R::::R     R:::::RO::::::O   O::::::O");
                    Console.WriteLine("C:::::C               U:::::D     D:::::U       A:::::A:::::A            T:::::T          R::::R     R:::::RO:::::O     O:::::O");
                    Console.WriteLine("C:::::C               U:::::D     D:::::U      A:::::A A:::::A           T:::::T          R::::RRRRRR:::::R O:::::O     O:::::O");
                    Console.WriteLine("C:::::C               U:::::D     D:::::U     A:::::A   A:::::A          T:::::T          R:::::::::::::RR  O:::::O     O:::::O");
                    Console.WriteLine("C:::::C               U:::::D     D:::::U    A:::::A     A:::::A         T:::::T          R::::RRRRRR:::::R O:::::O     O:::::O");
                    Console.WriteLine("C:::::C               U:::::D     D:::::U   A:::::AAAAAAAAA:::::A        T:::::T          R::::R     R:::::RO:::::O     O:::::O");
                    Console.WriteLine("C:::::C               U:::::D     D:::::U  A:::::::::::::::::::::A       T:::::T          R::::R     R:::::RO:::::O     O:::::O");
                    Console.WriteLine(" C:::::C       CCCCCC U::::::U   U::::::U A:::::AAAAAAAAAAAAA:::::A      T:::::T          R::::R     R:::::RO::::::O   O::::::O");
                    Console.WriteLine("  C:::::CCCCCCCC::::C U:::::::UUU:::::::UA:::::A             A:::::A   TT:::::::TT      RR:::::R     R:::::RO:::::::OOO:::::::O");
                    Console.WriteLine("   CC:::::::::::::::C  UU:::::::::::::UUA:::::A               A:::::A  T:::::::::T      R::::::R     R:::::R OO:::::::::::::OO ");
                    Console.WriteLine("     CCC::::::::::::C    UU:::::::::UU A:::::A                 A:::::A T:::::::::T      R::::::R     R:::::R   OO:::::::::OO");
                    Console.WriteLine("        CCCCCCCCCCCCC      UUUUUUUUU  AAAAAAA                   AAAAAAATTTTTTTTTTT      RRRRRRRR     RRRRRRR     OOOOOOOOO");
                    Console.WriteLine("Decenas");
                    break;

                case 5:
                    Console.WriteLine("        CCCCCCCCCCCCCIIIIIIIIIINNNNNNNN        NNNNNNNN        CCCCCCCCCCCCC     OOOOOOOOO");
                    Console.WriteLine("     CCC::::::::::::CI::::::::IN:::::::N       N::::::N     CCC::::::::::::C   OO:::::::::OO");
                    Console.WriteLine("   CC:::::::::::::::CI::::::::IN::::::::N      N::::::N   CC:::::::::::::::C OO:::::::::::::OO");
                    Console.WriteLine("  C:::::CCCCCCCC::::CII::::::IIN:::::::::N     N::::::N  C:::::CCCCCCCC::::CO:::::::OOO:::::::O");
                    Console.WriteLine(" C:::::C       CCCCCC  I::::I  N::::::::::N    N::::::N C:::::C       CCCCCCO::::::O   O::::::O");
                    Console.WriteLine("C:::::C                I::::I  N:::::::::::N   N::::::NC:::::C              O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                I::::I  N:::::::N::::N  N::::::NC:::::C              O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                I::::I  N::::::N N::::N N::::::NC:::::C              O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                I::::I  N::::::N  N::::N:::::::NC:::::C              O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                I::::I  N::::::N   N:::::::::::NC:::::C              O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                I::::I  N::::::N    N::::::::::NC:::::C              O:::::O     O:::::O");
                    Console.WriteLine(" C:::::C       CCCCCC  I::::I  N::::::N     N:::::::::N C:::::C       CCCCCCO::::::O   O::::::O");
                    Console.WriteLine("  C:::::CCCCCCCC::::CII::::::IIN::::::N      N::::::::N  C:::::CCCCCCCC::::CO:::::::OOO:::::::O");
                    Console.WriteLine("   CC:::::::::::::::CI::::::::IN::::::N       N:::::::N   CC:::::::::::::::C OO:::::::::::::OO");
                    Console.WriteLine("     CCC::::::::::::CI::::::::IN::::::N        N::::::N     CCC::::::::::::C   OO:::::::::OO");
                    Console.WriteLine("        CCCCCCCCCCCCCIIIIIIIIIINNNNNNNN         NNNNNNN        CCCCCCCCCCCCC     OOOOOOOOO ");
                    Console.WriteLine("Decenas");
                    break;

                case 6:
                    Console.WriteLine("   SSSSSSSSSSSSSSS EEEEEEEEEEEEEEEEEEEEEEIIIIIIIIII   SSSSSSSSSSSSSSS");
                    Console.WriteLine(" SS:::::::::::::::SE::::::::::::::::::::EI::::::::I SS:::::::::::::::S");
                    Console.WriteLine("S:::::SSSSSS::::::SE::::::::::::::::::::EI::::::::IS:::::SSSSSS::::::S");
                    Console.WriteLine("S:::::S     SSSSSSSEE::::::EEEEEEEEE::::EII::::::IIS:::::S     SSSSSSS");
                    Console.WriteLine("S:::::S              E:::::E       EEEEEE  I::::I  S:::::S");
                    Console.WriteLine("S:::::S              E:::::E               I::::I  S:::::S");
                    Console.WriteLine(" S::::SSSS           E::::::EEEEEEEEEE     I::::I   S::::SSSS");
                    Console.WriteLine("  SS::::::SSSSS      E:::::::::::::::E     I::::I    SS::::::SSSSS");
                    Console.WriteLine("    SSS::::::::SS    E:::::::::::::::E     I::::I      SSS::::::::SS");
                    Console.WriteLine("       SSSSSS::::S   E::::::EEEEEEEEEE     I::::I         SSSSSS::::S");
                    Console.WriteLine("            S:::::S  E:::::E               I::::I              S:::::S");
                    Console.WriteLine("            S:::::S  E:::::E       EEEEEE  I::::I              S:::::S");
                    Console.WriteLine("SSSSSSS     S:::::SEE::::::EEEEEEEE:::::EII::::::IISSSSSSS     S:::::S");
                    Console.WriteLine("S::::::SSSSSS:::::SE::::::::::::::::::::EI::::::::IS::::::SSSSSS:::::S");
                    Console.WriteLine("S:::::::::::::::SS E::::::::::::::::::::EI::::::::IS:::::::::::::::SS ");
                    Console.WriteLine(" SSSSSSSSSSSSSSS   EEEEEEEEEEEEEEEEEEEEEEIIIIIIIIII SSSSSSSSSSSSSSS ");
                    Console.WriteLine("Decenas");
                    break;

                case 7:
                    Console.WriteLine("   SSSSSSSSSSSSSSS IIIIIIIIIIEEEEEEEEEEEEEEEEEEEEEETTTTTTTTTTTTTTTTTTTTTTTEEEEEEEEEEEEEEEEEEEEEE");
                    Console.WriteLine(" SS:::::::::::::::SI::::::::IE::::::::::::::::::::ET:::::::::::::::::::::TE::::::::::::::::::::E");
                    Console.WriteLine("S:::::SSSSSS::::::SI::::::::IE::::::::::::::::::::ET:::::::::::::::::::::TE::::::::::::::::::::E");
                    Console.WriteLine("S:::::S     SSSSSSSII::::::IIEE::::::EEEEEEEEE::::ET:::::TT:::::::TT:::::TEE::::::EEEEEEEEE::::E");
                    Console.WriteLine("S:::::S              I::::I    E:::::E       EEEEEETTTTTT  T:::::T  TTTTTT  E:::::E       EEEEEE");
                    Console.WriteLine("S:::::S              I::::I    E:::::E                     T:::::T          E:::::E");
                    Console.WriteLine(" S::::SSSS           I::::I    E::::::EEEEEEEEEE           T:::::T          E::::::EEEEEEEEEE");
                    Console.WriteLine("  SS::::::SSSSS      I::::I    E:::::::::::::::E           T:::::T          E:::::::::::::::E");
                    Console.WriteLine("    SSS::::::::SS    I::::I    E:::::::::::::::E           T:::::T          E:::::::::::::::E");
                    Console.WriteLine("       SSSSSS::::S   I::::I    E::::::EEEEEEEEEE           T:::::T          E::::::EEEEEEEEEE ");
                    Console.WriteLine("            S:::::S  I::::I    E:::::E                     T:::::T          E:::::E");
                    Console.WriteLine("            S:::::S  I::::I    E:::::E       EEEEEE        T:::::T          E:::::E       EEEEEE");
                    Console.WriteLine("SSSSSSS     S:::::SII::::::IIEE::::::EEEEEEEE:::::E      TT:::::::TT      EE::::::EEEEEEEE:::::E");
                    Console.WriteLine("S::::::SSSSSS:::::SI::::::::IE::::::::::::::::::::E      T:::::::::T      E::::::::::::::::::::E");
                    Console.WriteLine("S:::::::::::::::SS I::::::::IE::::::::::::::::::::E      T:::::::::T      E::::::::::::::::::::E");
                    Console.WriteLine(" SSSSSSSSSSSSSSS   IIIIIIIIIIEEEEEEEEEEEEEEEEEEEEEE      TTTTTTTTTTT      EEEEEEEEEEEEEEEEEEEEEE");
                    Console.WriteLine("Decenas");
                    break;

                case 8:
                    Console.WriteLine("     OOOOOOOOO             CCCCCCCCCCCCCHHHHHHHHH     HHHHHHHHH     OOOOOOOOO");
                    Console.WriteLine("   OO:::::::::OO        CCC::::::::::::CH:::::::H     H:::::::H   OO:::::::::OO");
                    Console.WriteLine(" OO:::::::::::::OO    CC:::::::::::::::CH:::::::H     H:::::::H OO:::::::::::::OO");
                    Console.WriteLine("O:::::::OOO:::::::O  C:::::CCCCCCCC::::CHH::::::H     H::::::HHO:::::::OOO:::::::O");
                    Console.WriteLine("O::::::O   O::::::O C:::::C       CCCCCC  H:::::H     H:::::H  O::::::O   O::::::O");
                    Console.WriteLine("O:::::O     O:::::OC:::::C                H:::::H     H:::::H  O:::::O     O:::::O");
                    Console.WriteLine("O:::::O     O:::::OC:::::C                H::::::HHHHH::::::H  O:::::O     O:::::O");
                    Console.WriteLine("O:::::O     O:::::OC:::::C                H:::::::::::::::::H  O:::::O     O:::::O");
                    Console.WriteLine("O:::::O     O:::::OC:::::C                H:::::::::::::::::H  O:::::O     O:::::O");
                    Console.WriteLine("O:::::O     O:::::OC:::::C                H::::::HHHHH::::::H  O:::::O     O:::::O");
                    Console.WriteLine("O:::::O     O:::::OC:::::C                H:::::H     H:::::H  O:::::O     O:::::O");
                    Console.WriteLine("O::::::O   O::::::O C:::::C       CCCCCC  H:::::H     H:::::H  O::::::O   O::::::O");
                    Console.WriteLine("O:::::::OOO:::::::O  C:::::CCCCCCCC::::CHH::::::H     H::::::HHO:::::::OOO:::::::O");
                    Console.WriteLine(" OO:::::::::::::OO    CC:::::::::::::::CH:::::::H     H:::::::H OO:::::::::::::OO");
                    Console.WriteLine("   OO:::::::::OO        CCC::::::::::::CH:::::::H     H:::::::H   OO:::::::::OO");
                    Console.WriteLine("     OOOOOOOOO             CCCCCCCCCCCCCHHHHHHHHH     HHHHHHHHH     OOOOOOOOO");
                    Console.WriteLine("Decenas");
                    break;

                case 9:
                    Console.WriteLine("NNNNNNNN        NNNNNNNNUUUUUUUU     UUUUUUUUEEEEEEEEEEEEEEEEEEEEEEVVVVVVVV           VVVVVVVVEEEEEEEEEEEEEEEEEEEEEE");
                    Console.WriteLine("N:::::::N       N::::::NU::::::U     U::::::UE::::::::::::::::::::EV::::::V           V::::::VE::::::::::::::::::::E");
                    Console.WriteLine("N::::::::N      N::::::NU::::::U     U::::::UE::::::::::::::::::::EV::::::V           V::::::VE::::::::::::::::::::E");
                    Console.WriteLine("N:::::::::N     N::::::NUU:::::U     U:::::UUEE::::::EEEEEEEEE::::EV::::::V           V::::::VEE::::::EEEEEEEEE::::E");
                    Console.WriteLine("N::::::::::N    N::::::N U:::::U     U:::::U   E:::::E       EEEEEE V:::::V           V:::::V   E:::::E       EEEEEE");
                    Console.WriteLine("N:::::::::::N   N::::::N U:::::D     D:::::U   E:::::E               V:::::V         V:::::V    E:::::E");
                    Console.WriteLine("N:::::::N::::N  N::::::N U:::::D     D:::::U   E::::::EEEEEEEEEE      V:::::V       V:::::V     E::::::EEEEEEEEEE");
                    Console.WriteLine("N::::::N N::::N N::::::N U:::::D     D:::::U   E:::::::::::::::E       V:::::V     V:::::V      E:::::::::::::::E");
                    Console.WriteLine("N::::::N  N::::N:::::::N U:::::D     D:::::U   E:::::::::::::::E        V:::::V   V:::::V       E:::::::::::::::E");
                    Console.WriteLine("N::::::N   N:::::::::::N U:::::D     D:::::U   E::::::EEEEEEEEEE         V:::::V V:::::V        E::::::EEEEEEEEEE");
                    Console.WriteLine("N::::::N    N::::::::::N U:::::D     D:::::U   E:::::E                    V:::::V:::::V         E:::::E");
                    Console.WriteLine("N::::::N     N:::::::::N U::::::U   U::::::U   E:::::E       EEEEEE        V:::::::::V          E:::::E       EEEEEE");
                    Console.WriteLine("N::::::N      N::::::::N U:::::::UUU:::::::U EE::::::EEEEEEEE:::::E         V:::::::V         EE::::::EEEEEEEE:::::E");
                    Console.WriteLine("N::::::N       N:::::::N  UU:::::::::::::UU  E::::::::::::::::::::E          V:::::V          E::::::::::::::::::::E");
                    Console.WriteLine("N::::::N        N::::::N    UU:::::::::UU    E::::::::::::::::::::E           V:::V           E::::::::::::::::::::E");
                    Console.WriteLine("NNNNNNNN         NNNNNNN      UUUUUUUUU      EEEEEEEEEEEEEEEEEEEEEE            VVV            EEEEEEEEEEEEEEEEEEEEEE");
                    Console.WriteLine("Decenas");
                    break;

            }

           

            switch (cent)
            {

                case 0:
                    Console.WriteLine("        CCCCCCCCCCCCCEEEEEEEEEEEEEEEEEEEEEERRRRRRRRRRRRRRRRR        OOOOOOOOO");
                    Console.WriteLine("     CCC::::::::::::CE::::::::::::::::::::ER::::::::::::::::R     OO:::::::::OO");
                    Console.WriteLine("   CC:::::::::::::::CE::::::::::::::::::::ER::::::RRRRRR:::::R  OO:::::::::::::OO");
                    Console.WriteLine("  C:::::CCCCCCCC::::CEE::::::EEEEEEEEE::::ERR:::::R     R:::::RO:::::::OOO:::::::O");
                    Console.WriteLine(" C:::::C       CCCCCC  E:::::E       EEEEEE  R::::R     R:::::RO::::::O   O::::::O");
                    Console.WriteLine("C:::::C                E:::::E               R::::R     R:::::RO:::::O     O:::::O");
                    Console.WriteLine("C:::::C                E::::::EEEEEEEEEE     R::::RRRRRR:::::R O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                E:::::::::::::::E     R:::::::::::::RR  O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                E:::::::::::::::E     R::::RRRRRR:::::R O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                E::::::EEEEEEEEEE     R::::R     R:::::RO:::::O     O:::::O");
                    Console.WriteLine("C:::::C                E:::::E               R::::R     R:::::RO:::::O     O:::::O");
                    Console.WriteLine(" C:::::C       CCCCCC  E:::::E       EEEEEE  R::::R     R:::::RO::::::O   O::::::O");
                    Console.WriteLine("  C:::::CCCCCCCC::::CEE::::::EEEEEEEE:::::ERR:::::R     R:::::RO:::::::OOO:::::::O");
                    Console.WriteLine("   CC:::::::::::::::CE::::::::::::::::::::ER::::::R     R:::::R OO:::::::::::::OO");
                    Console.WriteLine("     CCC::::::::::::CE::::::::::::::::::::ER::::::R     R:::::R   OO:::::::::OO");
                    Console.WriteLine("        CCCCCCCCCCCCCEEEEEEEEEEEEEEEEEEEEEERRRRRRRR     RRRRRRR     OOOOOOOOO");
                    Console.WriteLine("Centenas");
                    break;

                case 1:
                    Console.WriteLine("UUUUUUUU     UUUUUUUUNNNNNNNN        NNNNNNNN     OOOOOOOOO ");
                    Console.WriteLine("U::::::U     U::::::UN:::::::N       N::::::N   OO:::::::::OO");
                    Console.WriteLine("U::::::U     U::::::UN::::::::N      N::::::N OO:::::::::::::OO");
                    Console.WriteLine("UU:::::U     U:::::UUN:::::::::N     N::::::NO:::::::OOO:::::::O");
                    Console.WriteLine(" U:::::U     U:::::U N::::::::::N    N::::::NO::::::O   O::::::O");
                    Console.WriteLine(" U:::::D     D:::::U N:::::::::::N   N::::::NO:::::O     O:::::O");
                    Console.WriteLine(" U:::::D     D:::::U N:::::::N::::N  N::::::NO:::::O     O:::::O");
                    Console.WriteLine(" U:::::D     D:::::U N::::::N N::::N N::::::NO:::::O     O:::::O");
                    Console.WriteLine(" U:::::D     D:::::U N::::::N  N::::N:::::::NO:::::O     O:::::O");
                    Console.WriteLine(" U:::::D     D:::::U N::::::N   N:::::::::::NO:::::O     O:::::O");
                    Console.WriteLine(" U:::::D     D:::::U N::::::N    N::::::::::NO:::::O     O:::::O");
                    Console.WriteLine(" U::::::U   U::::::U N::::::N     N:::::::::NO::::::O   O::::::O");
                    Console.WriteLine(" U:::::::UUU:::::::U N::::::N      N::::::::NO:::::::OOO:::::::O");
                    Console.WriteLine("  UU:::::::::::::UU  N::::::N       N:::::::N OO:::::::::::::OO ");
                    Console.WriteLine("    UU:::::::::UU    N::::::N        N::::::N   OO:::::::::OO");
                    Console.WriteLine("      UUUUUUUUU      NNNNNNNN         NNNNNNN     OOOOOOOOO");
                    Console.WriteLine("Centenas");
                    break;

                case 2:
                    Console.WriteLine("DDDDDDDDDDDDD             OOOOOOOOO        SSSSSSSSSSSSSSS");
                    Console.WriteLine("D::::::::::::DDD        OO:::::::::OO    SS:::::::::::::::S");
                    Console.WriteLine("D:::::::::::::::DD    OO:::::::::::::OO S:::::SSSSSS::::::S");
                    Console.WriteLine("DDD:::::DDDDD:::::D  O:::::::OOO:::::::OS:::::S     SSSSSSS");
                    Console.WriteLine("  D:::::D    D:::::D O::::::O   O::::::OS:::::S ");
                    Console.WriteLine("  D:::::D     D:::::DO:::::O     O:::::OS:::::S");
                    Console.WriteLine("  D:::::D     D:::::DO:::::O     O:::::O S::::SSSS");
                    Console.WriteLine("  D:::::D     D:::::DO:::::O     O:::::O  SS::::::SSSSS");
                    Console.WriteLine("  D:::::D     D:::::DO:::::O     O:::::O    SSS::::::::SS");
                    Console.WriteLine("  D:::::D     D:::::DO:::::O     O:::::O       SSSSSS::::S");
                    Console.WriteLine("  D:::::D     D:::::DO:::::O     O:::::O            S:::::S");
                    Console.WriteLine("  D:::::D    D:::::D O::::::O   O::::::O            S:::::S");
                    Console.WriteLine("DDD:::::DDDDD:::::D  O:::::::OOO:::::::OSSSSSSS     S:::::S");
                    Console.WriteLine("D:::::::::::::::DD    OO:::::::::::::OO S::::::SSSSSS:::::S");
                    Console.WriteLine("D::::::::::::DDD        OO:::::::::OO   S:::::::::::::::SS");
                    Console.WriteLine("DDDDDDDDDDDDD             OOOOOOOOO      SSSSSSSSSSSSSSS");
                    Console.WriteLine("Centenas");
                    break;

                case 3:
                    Console.WriteLine("TTTTTTTTTTTTTTTTTTTTTTTRRRRRRRRRRRRRRRRR   EEEEEEEEEEEEEEEEEEEEEE   SSSSSSSSSSSSSSS");
                    Console.WriteLine("T:::::::::::::::::::::TR::::::::::::::::R  E::::::::::::::::::::E SS:::::::::::::::S");
                    Console.WriteLine("T:::::::::::::::::::::TR::::::RRRRRR:::::R E::::::::::::::::::::ES:::::SSSSSS::::::S");
                    Console.WriteLine("T:::::TT:::::::TT:::::TRR:::::R     R:::::REE::::::EEEEEEEEE::::ES:::::S     SSSSSSS");
                    Console.WriteLine("TTTTTT  T:::::T  TTTTTT  R::::R     R:::::R  E:::::E       EEEEEES:::::S");
                    Console.WriteLine("        T:::::T          R::::R     R:::::R  E:::::E             S:::::S");
                    Console.WriteLine("        T:::::T          R::::RRRRRR:::::R   E::::::EEEEEEEEEE    S::::SSSS");
                    Console.WriteLine("        T:::::T          R:::::::::::::RR    E:::::::::::::::E     SS::::::SSSSS");
                    Console.WriteLine("        T:::::T          R::::RRRRRR:::::R   E:::::::::::::::E       SSS::::::::SS");
                    Console.WriteLine("        T:::::T          R::::R     R:::::R  E::::::EEEEEEEEEE          SSSSSS::::S");
                    Console.WriteLine("        T:::::T          R::::R     R:::::R  E:::::E                         S:::::S");
                    Console.WriteLine("        T:::::T          R::::R     R:::::R  E:::::E       EEEEEE            S:::::S");
                    Console.WriteLine("      TT:::::::TT      RR:::::R     R:::::REE::::::EEEEEEEE:::::ESSSSSSS     S:::::S");
                    Console.WriteLine("      T:::::::::T      R::::::R     R:::::RE::::::::::::::::::::ES::::::SSSSSS:::::S");
                    Console.WriteLine("      T:::::::::T      R::::::R     R:::::RE::::::::::::::::::::ES:::::::::::::::SS");
                    Console.WriteLine("      TTTTTTTTTTT      RRRRRRRR     RRRRRRREEEEEEEEEEEEEEEEEEEEEE SSSSSSSSSSSSSSS");
                    Console.WriteLine("Centenas");
                    break;

                case 4:
                    Console.WriteLine("        CCCCCCCCCCCCCUUUUUUUU     UUUUUUUU           AAA         TTTTTTTTTTTTTTTTTTTTTTTRRRRRRRRRRRRRRRRR        OOOOOOOOO");
                    Console.WriteLine("     CCC::::::::::::CU::::::U     U::::::U          A:::A        T:::::::::::::::::::::TR::::::::::::::::R     OO:::::::::OO");
                    Console.WriteLine("   CC:::::::::::::::CU::::::U     U::::::U         A:::::A       T:::::::::::::::::::::TR::::::RRRRRR:::::R  OO:::::::::::::OO");
                    Console.WriteLine("  C:::::CCCCCCCC::::CUU:::::U     U:::::UU        A:::::::A      T:::::TT:::::::TT:::::TRR:::::R     R:::::RO:::::::OOO:::::::O");
                    Console.WriteLine("  C:::::CCCCCCCC::::CUU:::::U     U:::::UU        A:::::::A      T:::::TT:::::::TT:::::TRR:::::R     R:::::RO:::::::OOO:::::::O");
                    Console.WriteLine(" C:::::C       CCCCCC U:::::U     U:::::U        A:::::::::A     TTTTTT  T:::::T  TTTTTT  R::::R     R:::::RO::::::O   O::::::O");
                    Console.WriteLine("C:::::C               U:::::D     D:::::U       A:::::A:::::A            T:::::T          R::::R     R:::::RO:::::O     O:::::O");
                    Console.WriteLine("C:::::C               U:::::D     D:::::U      A:::::A A:::::A           T:::::T          R::::RRRRRR:::::R O:::::O     O:::::O");
                    Console.WriteLine("C:::::C               U:::::D     D:::::U     A:::::A   A:::::A          T:::::T          R:::::::::::::RR  O:::::O     O:::::O");
                    Console.WriteLine("C:::::C               U:::::D     D:::::U    A:::::A     A:::::A         T:::::T          R::::RRRRRR:::::R O:::::O     O:::::O");
                    Console.WriteLine("C:::::C               U:::::D     D:::::U   A:::::AAAAAAAAA:::::A        T:::::T          R::::R     R:::::RO:::::O     O:::::O");
                    Console.WriteLine("C:::::C               U:::::D     D:::::U  A:::::::::::::::::::::A       T:::::T          R::::R     R:::::RO:::::O     O:::::O");
                    Console.WriteLine(" C:::::C       CCCCCC U::::::U   U::::::U A:::::AAAAAAAAAAAAA:::::A      T:::::T          R::::R     R:::::RO::::::O   O::::::O");
                    Console.WriteLine("  C:::::CCCCCCCC::::C U:::::::UUU:::::::UA:::::A             A:::::A   TT:::::::TT      RR:::::R     R:::::RO:::::::OOO:::::::O");
                    Console.WriteLine("   CC:::::::::::::::C  UU:::::::::::::UUA:::::A               A:::::A  T:::::::::T      R::::::R     R:::::R OO:::::::::::::OO ");
                    Console.WriteLine("     CCC::::::::::::C    UU:::::::::UU A:::::A                 A:::::A T:::::::::T      R::::::R     R:::::R   OO:::::::::OO");
                    Console.WriteLine("        CCCCCCCCCCCCC      UUUUUUUUU  AAAAAAA                   AAAAAAATTTTTTTTTTT      RRRRRRRR     RRRRRRR     OOOOOOOOO");
                    Console.WriteLine("Centenas");
                    break;

                case 5:
                    Console.WriteLine("        CCCCCCCCCCCCCIIIIIIIIIINNNNNNNN        NNNNNNNN        CCCCCCCCCCCCC     OOOOOOOOO");
                    Console.WriteLine("     CCC::::::::::::CI::::::::IN:::::::N       N::::::N     CCC::::::::::::C   OO:::::::::OO");
                    Console.WriteLine("   CC:::::::::::::::CI::::::::IN::::::::N      N::::::N   CC:::::::::::::::C OO:::::::::::::OO");
                    Console.WriteLine("  C:::::CCCCCCCC::::CII::::::IIN:::::::::N     N::::::N  C:::::CCCCCCCC::::CO:::::::OOO:::::::O");
                    Console.WriteLine(" C:::::C       CCCCCC  I::::I  N::::::::::N    N::::::N C:::::C       CCCCCCO::::::O   O::::::O");
                    Console.WriteLine("C:::::C                I::::I  N:::::::::::N   N::::::NC:::::C              O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                I::::I  N:::::::N::::N  N::::::NC:::::C              O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                I::::I  N::::::N N::::N N::::::NC:::::C              O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                I::::I  N::::::N  N::::N:::::::NC:::::C              O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                I::::I  N::::::N   N:::::::::::NC:::::C              O:::::O     O:::::O");
                    Console.WriteLine("C:::::C                I::::I  N::::::N    N::::::::::NC:::::C              O:::::O     O:::::O");
                    Console.WriteLine(" C:::::C       CCCCCC  I::::I  N::::::N     N:::::::::N C:::::C       CCCCCCO::::::O   O::::::O");
                    Console.WriteLine("  C:::::CCCCCCCC::::CII::::::IIN::::::N      N::::::::N  C:::::CCCCCCCC::::CO:::::::OOO:::::::O");
                    Console.WriteLine("   CC:::::::::::::::CI::::::::IN::::::N       N:::::::N   CC:::::::::::::::C OO:::::::::::::OO");
                    Console.WriteLine("     CCC::::::::::::CI::::::::IN::::::N        N::::::N     CCC::::::::::::C   OO:::::::::OO");
                    Console.WriteLine("        CCCCCCCCCCCCCIIIIIIIIIINNNNNNNN         NNNNNNN        CCCCCCCCCCCCC     OOOOOOOOO ");
                    Console.WriteLine("Centenas");
                    break;

                case 6:
                    Console.WriteLine("   SSSSSSSSSSSSSSS EEEEEEEEEEEEEEEEEEEEEEIIIIIIIIII   SSSSSSSSSSSSSSS");
                    Console.WriteLine(" SS:::::::::::::::SE::::::::::::::::::::EI::::::::I SS:::::::::::::::S");
                    Console.WriteLine("S:::::SSSSSS::::::SE::::::::::::::::::::EI::::::::IS:::::SSSSSS::::::S");
                    Console.WriteLine("S:::::S     SSSSSSSEE::::::EEEEEEEEE::::EII::::::IIS:::::S     SSSSSSS");
                    Console.WriteLine("S:::::S              E:::::E       EEEEEE  I::::I  S:::::S");
                    Console.WriteLine("S:::::S              E:::::E               I::::I  S:::::S");
                    Console.WriteLine(" S::::SSSS           E::::::EEEEEEEEEE     I::::I   S::::SSSS");
                    Console.WriteLine("  SS::::::SSSSS      E:::::::::::::::E     I::::I    SS::::::SSSSS");
                    Console.WriteLine("    SSS::::::::SS    E:::::::::::::::E     I::::I      SSS::::::::SS");
                    Console.WriteLine("       SSSSSS::::S   E::::::EEEEEEEEEE     I::::I         SSSSSS::::S");
                    Console.WriteLine("            S:::::S  E:::::E               I::::I              S:::::S");
                    Console.WriteLine("            S:::::S  E:::::E       EEEEEE  I::::I              S:::::S");
                    Console.WriteLine("SSSSSSS     S:::::SEE::::::EEEEEEEE:::::EII::::::IISSSSSSS     S:::::S");
                    Console.WriteLine("S::::::SSSSSS:::::SE::::::::::::::::::::EI::::::::IS::::::SSSSSS:::::S");
                    Console.WriteLine("S:::::::::::::::SS E::::::::::::::::::::EI::::::::IS:::::::::::::::SS ");
                    Console.WriteLine(" SSSSSSSSSSSSSSS   EEEEEEEEEEEEEEEEEEEEEEIIIIIIIIII SSSSSSSSSSSSSSS ");
                    Console.WriteLine("Centenas");
                    break;

                case 7:
                    Console.WriteLine("   SSSSSSSSSSSSSSS IIIIIIIIIIEEEEEEEEEEEEEEEEEEEEEETTTTTTTTTTTTTTTTTTTTTTTEEEEEEEEEEEEEEEEEEEEEE");
                    Console.WriteLine(" SS:::::::::::::::SI::::::::IE::::::::::::::::::::ET:::::::::::::::::::::TE::::::::::::::::::::E");
                    Console.WriteLine("S:::::SSSSSS::::::SI::::::::IE::::::::::::::::::::ET:::::::::::::::::::::TE::::::::::::::::::::E");
                    Console.WriteLine("S:::::S     SSSSSSSII::::::IIEE::::::EEEEEEEEE::::ET:::::TT:::::::TT:::::TEE::::::EEEEEEEEE::::E");
                    Console.WriteLine("S:::::S              I::::I    E:::::E       EEEEEETTTTTT  T:::::T  TTTTTT  E:::::E       EEEEEE");
                    Console.WriteLine("S:::::S              I::::I    E:::::E                     T:::::T          E:::::E");
                    Console.WriteLine(" S::::SSSS           I::::I    E::::::EEEEEEEEEE           T:::::T          E::::::EEEEEEEEEE");
                    Console.WriteLine("  SS::::::SSSSS      I::::I    E:::::::::::::::E           T:::::T          E:::::::::::::::E");
                    Console.WriteLine("    SSS::::::::SS    I::::I    E:::::::::::::::E           T:::::T          E:::::::::::::::E");
                    Console.WriteLine("       SSSSSS::::S   I::::I    E::::::EEEEEEEEEE           T:::::T          E::::::EEEEEEEEEE ");
                    Console.WriteLine("            S:::::S  I::::I    E:::::E                     T:::::T          E:::::E");
                    Console.WriteLine("            S:::::S  I::::I    E:::::E       EEEEEE        T:::::T          E:::::E       EEEEEE");
                    Console.WriteLine("SSSSSSS     S:::::SII::::::IIEE::::::EEEEEEEE:::::E      TT:::::::TT      EE::::::EEEEEEEE:::::E");
                    Console.WriteLine("S::::::SSSSSS:::::SI::::::::IE::::::::::::::::::::E      T:::::::::T      E::::::::::::::::::::E");
                    Console.WriteLine("S:::::::::::::::SS I::::::::IE::::::::::::::::::::E      T:::::::::T      E::::::::::::::::::::E");
                    Console.WriteLine(" SSSSSSSSSSSSSSS   IIIIIIIIIIEEEEEEEEEEEEEEEEEEEEEE      TTTTTTTTTTT      EEEEEEEEEEEEEEEEEEEEEE");
                    Console.WriteLine("Centenas");
                    break;

                case 8:
                    Console.WriteLine("     OOOOOOOOO             CCCCCCCCCCCCCHHHHHHHHH     HHHHHHHHH     OOOOOOOOO");
                    Console.WriteLine("   OO:::::::::OO        CCC::::::::::::CH:::::::H     H:::::::H   OO:::::::::OO");
                    Console.WriteLine(" OO:::::::::::::OO    CC:::::::::::::::CH:::::::H     H:::::::H OO:::::::::::::OO");
                    Console.WriteLine("O:::::::OOO:::::::O  C:::::CCCCCCCC::::CHH::::::H     H::::::HHO:::::::OOO:::::::O");
                    Console.WriteLine("O::::::O   O::::::O C:::::C       CCCCCC  H:::::H     H:::::H  O::::::O   O::::::O");
                    Console.WriteLine("O:::::O     O:::::OC:::::C                H:::::H     H:::::H  O:::::O     O:::::O");
                    Console.WriteLine("O:::::O     O:::::OC:::::C                H::::::HHHHH::::::H  O:::::O     O:::::O");
                    Console.WriteLine("O:::::O     O:::::OC:::::C                H:::::::::::::::::H  O:::::O     O:::::O");
                    Console.WriteLine("O:::::O     O:::::OC:::::C                H:::::::::::::::::H  O:::::O     O:::::O");
                    Console.WriteLine("O:::::O     O:::::OC:::::C                H::::::HHHHH::::::H  O:::::O     O:::::O");
                    Console.WriteLine("O:::::O     O:::::OC:::::C                H:::::H     H:::::H  O:::::O     O:::::O");
                    Console.WriteLine("O::::::O   O::::::O C:::::C       CCCCCC  H:::::H     H:::::H  O::::::O   O::::::O");
                    Console.WriteLine("O:::::::OOO:::::::O  C:::::CCCCCCCC::::CHH::::::H     H::::::HHO:::::::OOO:::::::O");
                    Console.WriteLine(" OO:::::::::::::OO    CC:::::::::::::::CH:::::::H     H:::::::H OO:::::::::::::OO");
                    Console.WriteLine("   OO:::::::::OO        CCC::::::::::::CH:::::::H     H:::::::H   OO:::::::::OO");
                    Console.WriteLine("     OOOOOOOOO             CCCCCCCCCCCCCHHHHHHHHH     HHHHHHHHH     OOOOOOOOO");
                    Console.WriteLine("Centenas");
                    break;

                case 9:
                    Console.WriteLine("NNNNNNNN        NNNNNNNNUUUUUUUU     UUUUUUUUEEEEEEEEEEEEEEEEEEEEEEVVVVVVVV           VVVVVVVVEEEEEEEEEEEEEEEEEEEEEE");
                    Console.WriteLine("N:::::::N       N::::::NU::::::U     U::::::UE::::::::::::::::::::EV::::::V           V::::::VE::::::::::::::::::::E");
                    Console.WriteLine("N::::::::N      N::::::NU::::::U     U::::::UE::::::::::::::::::::EV::::::V           V::::::VE::::::::::::::::::::E");
                    Console.WriteLine("N:::::::::N     N::::::NUU:::::U     U:::::UUEE::::::EEEEEEEEE::::EV::::::V           V::::::VEE::::::EEEEEEEEE::::E");
                    Console.WriteLine("N::::::::::N    N::::::N U:::::U     U:::::U   E:::::E       EEEEEE V:::::V           V:::::V   E:::::E       EEEEEE");
                    Console.WriteLine("N:::::::::::N   N::::::N U:::::D     D:::::U   E:::::E               V:::::V         V:::::V    E:::::E");
                    Console.WriteLine("N:::::::N::::N  N::::::N U:::::D     D:::::U   E::::::EEEEEEEEEE      V:::::V       V:::::V     E::::::EEEEEEEEEE");
                    Console.WriteLine("N::::::N N::::N N::::::N U:::::D     D:::::U   E:::::::::::::::E       V:::::V     V:::::V      E:::::::::::::::E");
                    Console.WriteLine("N::::::N  N::::N:::::::N U:::::D     D:::::U   E:::::::::::::::E        V:::::V   V:::::V       E:::::::::::::::E");
                    Console.WriteLine("N::::::N   N:::::::::::N U:::::D     D:::::U   E::::::EEEEEEEEEE         V:::::V V:::::V        E::::::EEEEEEEEEE");
                    Console.WriteLine("N::::::N    N::::::::::N U:::::D     D:::::U   E:::::E                    V:::::V:::::V         E:::::E");
                    Console.WriteLine("N::::::N     N:::::::::N U::::::U   U::::::U   E:::::E       EEEEEE        V:::::::::V          E:::::E       EEEEEE");
                    Console.WriteLine("N::::::N      N::::::::N U:::::::UUU:::::::U EE::::::EEEEEEEE:::::E         V:::::::V         EE::::::EEEEEEEE:::::E");
                    Console.WriteLine("N::::::N       N:::::::N  UU:::::::::::::UU  E::::::::::::::::::::E          V:::::V          E::::::::::::::::::::E");
                    Console.WriteLine("N::::::N        N::::::N    UU:::::::::UU    E::::::::::::::::::::E           V:::V           E::::::::::::::::::::E");
                    Console.WriteLine("NNNNNNNN         NNNNNNN      UUUUUUUUU      EEEEEEEEEEEEEEEEEEEEEE            VVV            EEEEEEEEEEEEEEEEEEEEEE");
                    Console.WriteLine("Centenas");
                    break;

            }

        }
    }
}
