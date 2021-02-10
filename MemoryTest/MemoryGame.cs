using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MemoryGame
{
    public class MemoryGame
    {
        public MainWindow f;
        public Card last = null;

        public Player player1 = new Player("Player 1", true);
        public Player player2 = new Player("Player 2", false);

        public List<Card> allTheCardsList = new List<Card>();
        public List<int> randomValuesList = new List<int>();

        private Score score = new Score();
        private Random r;

        public MemoryGame(MainWindow f)
        {
            Shuffle();
            this.f = f;
            int X = 10, Y = 10; // x=latime intre carti; y=inaltime intre carti
            for (int i = 0; i < 32; i++) //da aiurea daca fac 2x16 :(
            {
                Card c = new Card(Y, X, randomValuesList[i], this); //genereaza dinamic un picture box, la pozitia x si y si list[i]==valoarea cartii din foldrul meu
                X += 125;
                if (X > 1000)
                {
                    Y += 160;
                    X = 5;
                }
                allTheCardsList.Add(c); //il adauga in forma asta in lista principala
            }
        }

        public void DisableCards()
        {
            foreach (var card in allTheCardsList)
            {
                card.stayTurned = true;
                card.picture.Enabled = false;
            }
        }

        public void TurnBackCard()
        {
            foreach (var card in allTheCardsList)
            {
                if (card.stayTurned == false)  //??
                {
                    card.ShowTheBackOfTheCard();
                }
            }
        }

        public void TurnFaceCard()
        {
            foreach (var card in allTheCardsList)
            {
                card.ShowTheFaceOfTheCard();
            }
        }

        public void AddPictures()
        {
            foreach (var card in allTheCardsList)
            {
                f.Controls.Add(card.picture);
            }
        }

        public void IsNotMatching(Card cardToMatch)
        {
            cardToMatch.picture.Enabled = true;
            allTheCardsList.Find(x => x == last).picture.Enabled = true;
            allTheCardsList.Find(x => x == last).stayTurned = false;
            cardToMatch.stayTurned = false;
            last = null;
            TurnBackCard();
        }

        public void Shuffle()
        {
            for (int i = 1; i <= 16; i++)
            {
                randomValuesList.Add(i); //in lista bag 1122334455...
                randomValuesList.Add(i);
            }
            r = new Random();//instantiat random
            int n = randomValuesList.Count; //retin cat de lunga e lista

            while (n > 1) //cat timp mai sunt elemente in lista
            {
                n--; //scad din n
                int k = r.Next(n + 1); //k ia o valoare random pozitiva < la n+1
                var value = randomValuesList[k]; //o variabila value retine valoarea din lista de pe pozitia k
                randomValuesList[k] = randomValuesList[n]; //interschimbare simpla in lista a elementelor de pe valoarea n (care tot scade) cu variabila value care contine numere random pana la n+1
                randomValuesList[n] = value; //=>> in lista am de 2 ori toate valorile pana la 16 in ordine aleatoare
            }
        }

        public bool EndTheGame()
        {
            int counterifturend = 0;
            foreach (var card in allTheCardsList)
            {
                if (card.stayTurned == true)
                {
                    counterifturend++;
                }
            }
            if (counterifturend == 32)
            {
                ShowWhoWon();
                return true;
            }
            return false;
        }

        public void TurnCardsDelay()
        {
            Stopwatch sw = new Stopwatch(); //tot verifica daca a trecut timpul pe care l-am pus eu
            sw.Start(); //porneste starwatchul
            for (int i = 0; ; i++) //contor care se incrementeaza la fiecare milisecunda
            {
                if (i % 100000 == 0) // if in 100000th iteration (could be any other large number
                                     // depending on how often you want the time to be checked)
                {
                    sw.Stop(); //se opreste masuratoarea
                    if (sw.ElapsedMilliseconds > 700) // verifica daca au trecut cate ms au fost puse
                    {
                        break; //daca or trecut face break si gata
                    }
                    else
                    {
                        sw.Start(); // daca nu au trecut mai putin de 700 ms continua loopul adica reincepe stopwatchul
                    }
                }
            }
        }

        //clasele care se schimba
        public virtual void IsMatching(Card cardToMatch)
        {
        }

        public virtual void IncrementScoreIfCardsAreMatching()
        {
        }

        public virtual void DisableThePlayersTurnsLabels()
        {
        }

        public virtual void ShowWhoWon()
        {
        }
    }
}