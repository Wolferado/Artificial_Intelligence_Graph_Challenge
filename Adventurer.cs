﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtificialIntelligenceGraphChallenge
{
    // Klase, kura tiek izmantota kā paraugs ceļotājiem.
    internal class Adventurer
    {
        private int timeToCross { get; set; }
        private char identificationLetter { get; set; }

        public int GetTimeToCross()
        {
            return timeToCross;
        }

        public void SetTimeToCross(int time)
        {
            timeToCross = time;
        }

        public char GetIdentificationLetter()
        {
            return identificationLetter;
        }

        public void SetIdentificationLetter(char letter)
        {
            this.identificationLetter = letter;
        }
    }

    // Klase ceļotājam A.
    internal class Adventurer_A : Adventurer
    {
        public Adventurer_A()
        {
            SetTimeToCross(1);
            SetIdentificationLetter('A');
        }
    }

    // Klase ceļotājam B.
    internal class Adventurer_B : Adventurer
    {
        public Adventurer_B()
        {
            SetTimeToCross(3);
            SetIdentificationLetter('B');
        }
    }

    // Klase ceļotājam C.
    internal class Adventurer_C : Adventurer
    {
        public Adventurer_C()
        {
            SetTimeToCross(5);
            SetIdentificationLetter('C');
        }
    }
}
