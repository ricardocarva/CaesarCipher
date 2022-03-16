using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            

                /*
                 Caesar Cipher

                 This program encrypts and decrypts a message using the Caesar Cipher, which was used by the Roman Empire to encode military secrets.

       Plain	 A	B	C	D	E	F	G	H	I	J	K	L	M	N	O	P	Q	R	S	T	U	V	W	X	Y	Z
       Cipher X	Y	Z	A	B	C	D	E	F	G	H	I	J	K	L	M	N	O	P	Q	R	S	T	U	V	W

     Take every letter of your message and shift it three places to the right. For example, A becomes D, B becomes E, C becomes F, and “attack” becomes “dwwdfn”.

                 Author: Ricardo Carvalheira
                  */
                bool flag = true;
                do
                {
                    int programMode;
                    string userEntry;
                    do
                    {
                        string flagStr = "exit";
                        Console.Write("Please select the program mode:\r\n\r\n1 - Encrypt\r\n2 - Decrypt\r\n\r\nType \"exit\" to close program\r\n\r\nMode: ");
                        userEntry = Console.ReadLine();
                        if (!int.TryParse(userEntry, out programMode))
                        {
                            if (userEntry.Equals(flagStr)) { flag = false; break; }
                            Console.WriteLine("Not an Integer!");
                        }
                    } while (programMode != 1 && programMode != 2);
                    if (programMode == 1) Encrypt();

                    else if (programMode == 2)
                        Decrypt();

                } while (flag);


                Console.WriteLine("Press Enter to end program");
                Console.ReadLine();
            }
            static void Encrypt()
            {
                char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

                Console.Write("Enter Secret Message:");
                string secretMessageStr = Console.ReadLine();
                secretMessageStr = secretMessageStr.ToLower();
                char[] secretMessage = secretMessageStr.ToCharArray();
                char[] encryptedMessage = new char[secretMessage.Length];
                char letter;
                int index;

                for (int i = 0; i < secretMessage.Length; i++)
                {
                    letter = secretMessage[i];
                    if (Char.IsLetter(letter))
                    {
                        index = Array.IndexOf(alphabet, letter);
                        encryptedMessage[i] = alphabet[(index + 3) % 26];
                    }


                    else if (letter == ' ')
                    {
                        encryptedMessage[i] = ' ';
                    }

                }

                string msgString = String.Join("", encryptedMessage);
                Console.WriteLine($"The encrypted message is {msgString}");

            }
            static void Decrypt()
            {

                char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

                Console.Write("Enter Secret Message:");
                string secretMessageStr = Console.ReadLine();
                secretMessageStr = secretMessageStr.ToLower();
                char[] secretMessage = secretMessageStr.ToCharArray();
                char[] encryptedMessage = new char[secretMessage.Length];
                char letter;
                int index;

                for (int i = 0; i < secretMessage.Length; i++)
                {
                    letter = secretMessage[i];
                    if (Char.IsLetter(letter))
                    {
                        index = Array.IndexOf(alphabet, letter);
                        encryptedMessage[i] = alphabet[(index + 23) % 26];
                    }

                    else if (letter == ' ')
                    {
                        encryptedMessage[i] = ' ';
                    }

                }

                string msgString = String.Join("", encryptedMessage);
                Console.WriteLine($"The decrypted message is {msgString}");
            }
        }
}
