using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

/*
 * Laís Lyra Hatencia, 180471
 * Ingrid Mariana Inácio Jesus, 
 * 
 * 
 * O que falta fazer: Mostrar feedback sonoro, esconder a carta do oponente depois de certo tempo mostrando
 * 
*/

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static int qntCartas = 4;
        static int qntCartasOponente = 4;
        Carta[] cartasJogador = new Carta[8];
        Carta[] cartasOponente = new Carta[8];

        public Form1()
        {
            InitializeComponent();
        }

        //////////////////////////////////////// FUNÇÃO MAIN /////////////////////////////////////////
        private void Form1_Load(object sender, EventArgs e)
        {
            // distribui as oito cartas em dois vetores de quatro aleatoriamente, sem repetir
            Distribuir();

            Mostrar(cartasJogador, true);
            Ocultar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ganhou = 0;

            // vê qual atributo foi escolhido e compara
            if (radioButton1.Checked)
            {
                if (cartasJogador[0].atr.altura > cartasOponente[0].atr.altura)
                {
                    ganhou = 1;
                }
                else if (cartasJogador[0].atr.altura < cartasOponente[0].atr.altura)
                {
                    ganhou = -1;
                }

            } else if (radioButton2.Checked)
            {
                if (cartasJogador[0].atr.comprimento > cartasOponente[0].atr.comprimento)
                {
                    ganhou = 1;
                }
                else if (cartasJogador[0].atr.comprimento < cartasOponente[0].atr.comprimento)
                {
                    ganhou = -1;
                }

            } else if (radioButton3.Checked)
            {
                if (cartasJogador[0].atr.peso > cartasOponente[0].atr.peso)
                {
                    ganhou = 1;
                }
                else if (cartasJogador[0].atr.peso < cartasOponente[0].atr.peso)
                {
                    ganhou = -1;
                }

            } else if (radioButton4.Checked)
            {
                if (cartasJogador[0].atr.idade > cartasOponente[0].atr.idade)
                {
                    ganhou = 1;
                }
                else if (cartasJogador[0].atr.idade < cartasOponente[0].atr.idade)
                {
                    ganhou = -1;
                }

            }
            else
            {
                MessageBox.Show("Você precisa selecionar um atributo!");
            }

            // apenas se um dos botões estiver checado podemos prosseguir
            if ((radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked) && qntCartas < 8)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;

                // mostra um pouco a carta do oponente, e depois para

                Mostrar(cartasOponente, false);
                Refresh();
                System.Threading.Thread.Sleep(3000);

                // aumenta a quantidade de cartas de quem ganhou, e diminui do outro
                if (ganhou == 1)
                {
                    PassaParaTras(cartasJogador, qntCartas, 0);
                    qntCartas++;
                    cartasJogador[qntCartas - 1] = cartasOponente[0];
                    PassaParaTras(cartasOponente, qntCartasOponente, 0);
                    qntCartasOponente--;
                }
                else if (ganhou == -1)
                {
                    PassaParaTras(cartasOponente, qntCartasOponente, 0);
                    qntCartasOponente++;
                    cartasOponente[qntCartasOponente - 1] = cartasJogador[0];
                    PassaParaTras(cartasJogador, qntCartas, 0);
                    qntCartas--;
                }
                else
                {
                    PassaParaTras(cartasJogador, qntCartas, 0);
                    PassaParaTras(cartasOponente, qntCartasOponente, 0);
                }



                // verificar se ganhou ou perdeu
                if (qntCartas == 8)
                {
                    MessageBox.Show("Você ganhou!");
                }
                else if (qntCartas == 0)
                {
                    MessageBox.Show("Você perdeu!");
                }

                // por fim mostra as cartas do jogador atualizadas
                Mostrar(cartasJogador, true);
                Ocultar();

            }

        }

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            qntCartas = 4;
            qntCartasOponente = 4;

            Distribuir();

            Mostrar(cartasJogador, true);
            Ocultar();
        }

        // cria todas as variáveis que compõe uma carta
        struct Carta
        {
            public string nome;
            public string num;
            public Atributos atr;
        }
        struct Atributos
        {
            public float altura, comprimento;
            public int peso, idade;
        }

        // cria as cartas do trunfo
        private Carta[] CriarCartas()
        {
            Carta dino1 = new Carta();
            dino1.nome = "Herrerassauro";
            dino1.num = "1A";
            dino1.atr.altura = 1.5f;
            dino1.atr.comprimento = 4.5f;
            dino1.atr.peso = 300;
            dino1.atr.idade = 231;

            Carta dino2 = new Carta();
            dino2.nome = "Procompsognato";
            dino2.num = "1B";
            dino2.atr.altura = 0.3f;
            dino2.atr.comprimento = 1.2f;
            dino2.atr.peso = 1;
            dino2.atr.idade = 222;

            Carta dino3 = new Carta();
            dino3.nome = "Patagossauro";
            dino3.num = "1C";
            dino3.atr.altura = 8f;
            dino3.atr.comprimento = 18f;
            dino3.atr.peso = 16000;
            dino3.atr.idade = 169;

            Carta dino4 = new Carta();
            dino4.nome = "Ceratossauro";
            dino4.num = "1D";
            dino4.atr.altura = 2f;
            dino4.atr.comprimento = 6f;
            dino4.atr.peso = 1000;
            dino4.atr.idade = 156;

            Carta dino5 = new Carta();
            dino5.nome = "Pterodáctilo";
            dino5.num = "2A";
            dino5.atr.altura = 0.5f;
            dino5.atr.comprimento = 1f;
            dino5.atr.peso = 1;
            dino5.atr.idade = 150;

            Carta dino6 = new Carta();
            dino6.nome = "Velociraptor";
            dino6.num = "2B";
            dino6.atr.altura = 1f;
            dino6.atr.comprimento = 1.8f;
            dino6.atr.peso = 15;
            dino6.atr.idade = 80;

            Carta dino7 = new Carta();
            dino7.nome = "Triceratopo";
            dino7.num = "2C";
            dino7.atr.altura = 6f;
            dino7.atr.comprimento = 9f;
            dino7.atr.peso = 6000;
            dino7.atr.idade = 68;

            Carta dino8 = new Carta();
            dino8.nome = "Baptornis";
            dino8.num = "2D";
            dino8.atr.altura = 0.8f;
            dino8.atr.comprimento = 1f;
            dino8.atr.peso = 7;
            dino8.atr.idade = 83;

            Carta[] v = new Carta[8];
            v[0] = dino1;
            v[1] = dino2;
            v[2] = dino3;
            v[3] = dino4;
            v[4] = dino5;
            v[5] = dino6;
            v[6] = dino7;
            v[7] = dino8;

            return v;
        }

        // mostra a primeira carta do jogador ou do oponente na tela
        private void Mostrar(Carta[] carta, bool jogador)
        {
            if (jogador)
            {
                lbl_qntCartas.Text = "Nº de cartas: " + qntCartas;
                lbl_MyTitle.Text = carta[0].num + " " + carta[0].nome.ToUpper();
                lbl_MyAtr.Text = "Altura (m): " + carta[0].atr.altura + "\n\nComprimento (m): " + carta[0].atr.comprimento + "\n\nPeso (Kg): " + carta[0].atr.peso + "\n\nViveu há (10^6 anos): " + carta[0].atr.idade + "\n";
            }
            else
            {
                lbl_Interrogacao.Text = "";
                lbl_qntCartasOponente.Text = "Nº de cartas: " + qntCartasOponente;
                lbl_otherTitle.Text = carta[0].num + " " + carta[0].nome.ToUpper();
                lbl_otherAtr.Text = "Altura (m): " + carta[0].atr.altura + "\n\nComprimento (m): " + carta[0].atr.comprimento + "\n\nPeso (Kg): " + carta[0].atr.peso + "\n\nViveu há (10^6 anos): " + carta[0].atr.idade + "\n";
            }

        }

        // oculta a carta do oponente
        private void Ocultar()
        {
            lbl_qntCartasOponente.Text = "Nº de cartas: " + qntCartasOponente;
            lbl_otherTitle.Text = "";
            lbl_otherAtr.Text = "";
            lbl_Interrogacao.Text = "?";
        }

        // embaralha as cartas
        private void Distribuir()
        {
            Carta[] vetor = CriarCartas();

            Random rnd = new Random();


            for (int i = 0; i < 4; i++)
            {
                cartasJogador[i] = vetor[rnd.Next(0, 8)];
                for (int j = 0; j < i; j++)
                {
                    if (cartasJogador[i].num == cartasJogador[j].num)
                    {
                        i--;
                        break;
                    }
                }
            }


            for (int i = 0; i < 4; i++)
            {
                cartasOponente[i] = vetor[rnd.Next(0, 8)];
                for (int j = 0; j < i; j++)
                {
                    if (cartasOponente[i].num == cartasOponente[j].num)
                    {
                        i--;
                        break;
                    }
                }

                for (int j = 0; j < 4; j++)
                {
                    if (cartasOponente[i].num == cartasJogador[j].num)
                    {
                        i--;
                        break;
                    }
                }
            }
        }

        //passa as cartas para trás depois de serem usadas
        static void PassaParaTras(Carta[] vetor, int quantidade, int indice)
        {
            if (indice == quantidade - 1)
                return;

            Carta aux;
            aux = vetor[indice];
            vetor[indice] = vetor[indice + 1];
            vetor[indice + 1] = aux;

            PassaParaTras(vetor, quantidade, indice + 1);
        }

        // aumenta ou diminui o numero d cartas
        static void MudarNumDeCartas(int num)
        {
            qntCartas += num;
            qntCartasOponente -= num;
        }

    }
}
