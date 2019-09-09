using System;
using System.Collections.Generic;

namespace Eliminatoria_Copa {
    class Program {

        static void Main(string[] args) {

            List<string> class_semi = new List<string>();
            List<string> class_final = new List<string>();
            List<string> class_disp_terc = new List<string>();

            //Cadastro do nome dos times do torneio
            Console.WriteLine("Digite o nome dos times do Torneio na ordem: ");
            Console.Write("Time A: ");
            string A = Console.ReadLine();
            Console.Write("Time B: ");
            string B = Console.ReadLine();
            Console.Write("Time C: ");
            string C = Console.ReadLine();
            Console.Write("Time D: ");
            string D = Console.ReadLine();
            Console.Write("Time E: ");
            string E = Console.ReadLine();
            Console.Write("Time F: ");
            string F = Console.ReadLine();
            Console.Write("Time G: ");
            string G = Console.ReadLine();
            Console.Write("Time H: ");
            string H = Console.ReadLine();

            //Definição das chaves das Quartas de final
            Console.WriteLine("\nChave 1: ");
            Console.WriteLine(A + " X " + B);
            Console.WriteLine("\nChave 2: ");
            Console.WriteLine(C + " X " + D);
            Console.WriteLine("\nChave 3: ");
            Console.WriteLine(E + " X " + F);
            Console.WriteLine("\nChave 4: ");
            Console.WriteLine(G + " X " + H);

            //Resultado da primeira partida da Quarta de final.
            Console.WriteLine("\nResultado dos jogos da Quarta de final: ");
            Console.WriteLine("\nPrimeiro jogo (Chave 1): ");
            Console.Write(A + ": ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write(B + ": ");
            int b1 = int.Parse(Console.ReadLine());

            while (a1 == b1) {
                Console.WriteLine("\nO Resultado deve considerar as penalidades para que não haja empate!" + "\nDigite novamente o resultado do primeiro jogo (Chave 1): ");
                Console.Write(A + ": ");
                a1 = int.Parse(Console.ReadLine());
                Console.Write(B + ": ");
                b1 = int.Parse(Console.ReadLine());
                break;
            }

            //Resultado da segunda partida da Quarta de final.
            Console.WriteLine("\nPrimeiro jogo (Chave 2): ");
            Console.Write(C + ": ");
            int c1 = int.Parse(Console.ReadLine());
            Console.Write(D + ": ");
            int d1 = int.Parse(Console.ReadLine());

            while (c1 == d1) {
                Console.WriteLine("\nO Resultado deve considerar as penalidades para que não haja empate!" + "\nDigite novamente o resultado do primeiro jogo (Chave 2): ");
                Console.Write(C + ": ");
                c1 = int.Parse(Console.ReadLine());
                Console.Write(D + ": ");
                d1 = int.Parse(Console.ReadLine());
                break;
            }

            //Resultado da terceira partida da Quarta de final.
            Console.WriteLine("\nPrimeiro jogo (Chave 3): ");
            Console.Write(E + ": ");
            int e1 = int.Parse(Console.ReadLine());
            Console.Write(F + ": ");
            int f1 = int.Parse(Console.ReadLine());

            while (e1 == f1) {
                Console.WriteLine("\nO Resultado deve considerar as penalidades para que não haja empate!" + "\nDigite novamente o resultado do primeiro jogo (Chave 3): ");
                Console.Write(E + ": ");
                e1 = int.Parse(Console.ReadLine());
                Console.Write(F + ": ");
                f1 = int.Parse(Console.ReadLine());
                break;
            }

            //Resultado da ultima partida da Quarta de final.
            Console.WriteLine("\nPrimeiro jogo (Chave 4): ");
            Console.Write(G + ": ");
            int g1 = int.Parse(Console.ReadLine());
            Console.Write(H + ": ");
            int h1 = int.Parse(Console.ReadLine());

            while (g1 == h1) {
                Console.WriteLine("\nO Resultado deve considerar as penalidades para que não haja empate!" + "\nDigite novamente o resultado do primeiro jogo (Chave 4): ");
                Console.Write(G + ": ");
                g1 = int.Parse(Console.ReadLine());
                Console.Write(H + ": ");
                h1 = int.Parse(Console.ReadLine());
                break;
            }

            int resultado1 = Maior(b1, a1);
            int resultado2 = Maior(d1, c1);
            int resultado3 = Maior(f1, e1);
            int resultado4 = Maior(h1, g1);

            if (resultado1 == 1 && resultado2 == 1 && resultado3 == 1 && resultado4 == 1) {
                class_semi.AddRange(new string[] { A, C, E, G });
            } else if (resultado1 == 1 && resultado2 == 1 && resultado3 == 1 && resultado4 == 2) {
                class_semi.AddRange(new string[] { A, C, E, H });
            } else if (resultado1 == 1 && resultado2 == 1 && resultado3 == 2 && resultado4 == 2) {
                class_semi.AddRange(new string[] { A, C, F, H });
            } else if (resultado1 == 1 && resultado2 == 2 && resultado3 == 2 && resultado4 == 2) {
                class_semi.AddRange(new string[] { A, D, F, H });
            } else if (resultado1 == 2 && resultado2 == 2 && resultado3 == 2 && resultado4 == 2) {
                class_semi.AddRange(new string[] { A, D, F, H });
            } else if (resultado1 == 2 && resultado2 == 2 && resultado3 == 2 && resultado4 == 1) {
                class_semi.AddRange(new string[] { B, D, F, G });
            } else if (resultado1 == 2 && resultado2 == 2 && resultado3 == 1 && resultado4 == 1) {
                class_semi.AddRange(new string[] { B, D, E, G });
            } else if (resultado1 == 2 && resultado2 == 1 && resultado3 == 1 && resultado4 == 1) {
                class_semi.AddRange(new string[] { B, C, E, G });
            } else if (resultado1 == 1 && resultado2 == 2 && resultado3 == 1 && resultado4 == 2) {
                class_semi.AddRange(new string[] { A, D, E, H });
            } else if (resultado1 == 2 && resultado2 == 1 && resultado3 == 2 && resultado4 == 1) {
                class_semi.AddRange(new string[] { B, C, F, G });
            } else if (resultado1 == 1 && resultado2 == 2 && resultado3 == 2 && resultado4 == 1) {
                class_semi.AddRange(new string[] { A, D, F, G });
            } else if (resultado1 == 2 && resultado2 == 1 && resultado3 == 1 && resultado4 == 2) {
                class_semi.AddRange(new string[] { B, C, E, H });
            } else if (resultado1 == 1 && resultado2 == 2 && resultado3 == 1 && resultado4 == 1) {
                class_semi.AddRange(new string[] { A, D, E, G });
            } else if (resultado1 == 1 && resultado2 == 1 && resultado3 == 2 && resultado4 == 1) {
                class_semi.AddRange(new string[] { A, C, F, G });
            } else if (resultado1 == 2 && resultado2 == 1 && resultado3 == 2 && resultado4 == 2) {
                class_semi.AddRange(new string[] { B, C, F, H });
            } else if (resultado1 == 2 && resultado2 == 2 && resultado3 == 1 && resultado4 == 2) {
                class_semi.AddRange(new string[] { B, D, E, H });
            }

            //Definição da classificação para as Semifinais.
            Console.WriteLine("\nSemifinal 1: ");
            Console.WriteLine(class_semi[0] + " X " + class_semi[1]);
            Console.WriteLine("\nSemifinal 2: ");
            Console.WriteLine(class_semi[2] + " X " + class_semi[3]);

            //Resultado da primeira partida da Semifinal.
            Console.WriteLine("\nResultado dos jogos de Semifinal: ");
            Console.WriteLine("\nPrimeiro jogo: ");
            Console.Write(class_semi[0] + ": ");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write(class_semi[1] + ": ");
            int b2 = int.Parse(Console.ReadLine());

            while (a2 == b2) {
                Console.WriteLine("\nO Resultado deve considerar as penalidades para que não haja empate!" + "\nDigite novamente o resultado do jogo: ");
                Console.Write(class_semi[0] + ": ");
                a2 = int.Parse(Console.ReadLine());
                Console.Write(class_semi[1] + ": ");
                b2 = int.Parse(Console.ReadLine());
                break;
            }

            //Resultado da segunda partida da Semifinal.
            Console.WriteLine("\nSegundo jogo: ");
            Console.Write(class_semi[2] + ": ");
            int c2 = int.Parse(Console.ReadLine());
            Console.Write(class_semi[3] + ": ");
            int d2 = int.Parse(Console.ReadLine());

            while (c2 == d2) {
                Console.WriteLine("\nO Resultado deve considerar as penalidades para que não haja empate!" + "\nDigite novamente o resultado do jogo: ");
                Console.Write(class_semi[3] + ": ");
                c2 = int.Parse(Console.ReadLine());
                Console.Write(class_semi[4] + ": ");
                d2 = int.Parse(Console.ReadLine());
                break;
            }

            int resultado5 = Maior(b2, a2);
            int resultado6 = Maior(d2, c2);

            if (resultado5 == 1 && resultado6 == 1) {
                class_final.AddRange(new string[] { class_semi[0], class_semi[2] });
                class_disp_terc.AddRange(new string[] { class_semi[1], class_semi[3] });
            } else if (resultado5 == 1 && resultado6 == 2) {
                class_final.AddRange(new string[] { class_semi[0], class_semi[3] });
                class_disp_terc.AddRange(new string[] { class_semi[1], class_semi[2] });
            } else if (resultado5 == 2 && resultado6 == 2) {
                class_final.AddRange(new string[] { class_semi[1], class_semi[3] });
                class_disp_terc.AddRange(new string[] { class_semi[0], class_semi[2] });
            } else if (resultado5 == 2 && resultado6 == 1) {
                class_final.AddRange(new string[] { class_semi[1], class_semi[2] });
                class_disp_terc.AddRange(new string[] { class_semi[0], class_semi[3] });
            }

            //Definição da classificação para a final e disputa do terceiro lugar.
            Console.WriteLine("\nDisputa para o terceiro lugar: ");
            Console.WriteLine(class_disp_terc[0] + " X " + class_disp_terc[1]);
            Console.WriteLine("\nFinal: ");
            Console.WriteLine(class_final[0] + " X " + class_final[1]);

            //Resultado da disputa do terceiro lugar.
            Console.WriteLine("\nResultado do jogo para definição do terceiro colocado no torneio: ");
            Console.Write(class_disp_terc[0] + ": ");
            int a3 = int.Parse(Console.ReadLine());
            Console.Write(class_disp_terc[1] + ": ");
            int b3 = int.Parse(Console.ReadLine());

            while (a3 == b3) {
                Console.WriteLine("\nO Resultado deve considerar as penalidades para que não haja empate!" + "\nDigite novamente o resultado jogo: ");
                Console.Write(class_disp_terc[0] + ": ");
                a3 = int.Parse(Console.ReadLine());
                Console.Write(class_disp_terc[1] + ": ");
                b3 = int.Parse(Console.ReadLine());
                break;
            }

            //Resultado da final.
            Console.WriteLine("\nResultado do jogo da final: ");
            Console.Write(class_final[0] + ": ");
            int a4 = int.Parse(Console.ReadLine());
            Console.Write(class_final[1] + ": ");
            int b4 = int.Parse(Console.ReadLine());

            while (a4 == b4) {
                Console.WriteLine("\nO Resultado deve considerar as penalidades para que não haja empate!" + "\nDigite novamente o resultado jogo: ");
                Console.Write(class_final[0] + ": ");
                a4 = int.Parse(Console.ReadLine());
                Console.Write(class_final[1] + ": ");
                b4 = int.Parse(Console.ReadLine());
                break;
            }

            int resultado7 = Maior(b3, a3);
            int resultado8 = Maior(b4, a4);

            if (resultado7 == 1) {
                Console.WriteLine("\nA equipe " + class_disp_terc[0] + " ficou em terceiro lugar");
            } else {
                Console.WriteLine("\nA equipe " + class_disp_terc[1] + " ficou em terceiro lugar");
            }

            if (resultado8 == 1) {
                Console.WriteLine("\nA equipe " + class_final[1] + " ficou em segundo lugar");
                Console.WriteLine("\nA equipe " + class_final[0] + " ficou em primeiro lugar");
            } else {
                Console.WriteLine("\nA equipe " + class_final[0] + " ficou em segundo lugar");
                Console.WriteLine("\nA equipe " + class_final[1] + " ficou em primeiro lugar");
            }
        }

        static int Maior(int b, int a) {
            int m1;
            if (a > b) {
                m1 = 1;
            } else if (a < b) {
                m1 = 2;
            } else {
                m1 = 0;
            }
            return m1;
        }

    }
}