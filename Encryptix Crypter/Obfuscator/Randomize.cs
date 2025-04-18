﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypter.Obfuscator
{
    class Randomize
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string RandomCharacters(int length)
        {
            const string chars = "🥰🤩😶‍🌫️🥴🥵🤔🤭🤕😳😜💘🗨️💣😿😣😵‍💫🫁🏳️‍⚧️🤵🏼‍♂️🪠";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        
    }
}
