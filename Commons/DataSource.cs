using Microsoft.Xaml.Behaviors.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrambled_Word_WPF_Project.Commons
{
    public class DataSource 
    {
        public static string scrambledWordInfo(int listKeyNum, int randomNum)
        {
            List<string> _easyWords = new List<string>();
            {
                _easyWords.Add("adjust");
                _easyWords.Add("bead");
                _easyWords.Add("cheer");
                _easyWords.Add("cloud");
                _easyWords.Add("dirt");
                _easyWords.Add("east");
                _easyWords.Add("erupt");
                _easyWords.Add("infern");
                _easyWords.Add("jacket");
                _easyWords.Add("knight");
                _easyWords.Add("label");
                _easyWords.Add("miles");
                _easyWords.Add("nature");
                _easyWords.Add("nudge");
                _easyWords.Add("quick");
                _easyWords.Add("reap");
                _easyWords.Add("rescue");
                _easyWords.Add("smile");
                _easyWords.Add("sword");
                _easyWords.Add("wasp");
                _easyWords.Add("knight");
            }

            List<string> _AverageWords = new List<string>();
            {
                _AverageWords.Add("acrobat");
                _AverageWords.Add("algorithm");
                _AverageWords.Add("artificial");
                _AverageWords.Add("biometrics");
                _AverageWords.Add("browser");
                _AverageWords.Add("confection");
                _AverageWords.Add("encrypt");
                _AverageWords.Add("firewall");
                _AverageWords.Add("innovate");
                _AverageWords.Add("interface");
                _AverageWords.Add("internet");
                _AverageWords.Add("justice");
                _AverageWords.Add("mystery");
                _AverageWords.Add("network");
                _AverageWords.Add("passion");
                _AverageWords.Add("pleasant");
                _AverageWords.Add("procedure");
                _AverageWords.Add("programming");
                _AverageWords.Add("software");
                _AverageWords.Add("ventilate");
            }
            List<string> _hardWords = new List<string>();
            {
                _hardWords.Add("authenticate");
                _hardWords.Add("asynchronous");
                _hardWords.Add("augmented reality");
                _hardWords.Add("authenticate");
                _hardWords.Add("blockchain");
                _hardWords.Add("concatenation");
                _hardWords.Add("cryptocurrency");
                _hardWords.Add("cybersecurity");
                _hardWords.Add("electromagnetism");
                _hardWords.Add("encapsulation");
                _hardWords.Add("engineering");
                _hardWords.Add("holography");
                _hardWords.Add("quantum mechanics");
                _hardWords.Add("internet of things");
                _hardWords.Add("machine learning");
                _hardWords.Add("nanotechnology");
                _hardWords.Add("quantum computing");
                _hardWords.Add("recursion");
                _hardWords.Add("telecommunications");
                _hardWords.Add("virtual reality");
            }

            if (listKeyNum == 1)
            {    
                return _easyWords[randomNum];
            }
            else if (listKeyNum == 2)
            {
                return _AverageWords[randomNum];
            }
            else if(listKeyNum == 3)
            {
                return _hardWords[randomNum];
            }
            else
            {
                return null;
            }
        }
        public static string scrambledWordHint(int listKeyNum, int num)
        {
            List<string> _easyHints = new List<string>();
            {
                _easyHints.Add("Make a change or alteration to something.");
                _easyHints.Add("Small, often spherical, object typically strung together.");
                _easyHints.Add("A joyful expression or to express happiness.");
                _easyHints.Add("Fluffy masses in the sky, sometimes bring rain.");
                _easyHints.Add("Soil or earth, often found in gardens or on the ground.");
                _easyHints.Add("The direction where the sun rises.");
                _easyHints.Add("When a volcano blows its top.");
                _easyHints.Add("A fiery place of punishment in some beliefs.");
                _easyHints.Add("Clothing worn on the upper body, often with sleeves.");
                _easyHints.Add("A medieval warrior, often associated with chivalry.");
                _easyHints.Add("A piece of paper or material attached to an object, providing information about it.");
                _easyHints.Add("A unit of distance measurement.");
                _easyHints.Add("The natural world and its phenomena.");
                _easyHints.Add("A gentle push or encouragement.");
                _easyHints.Add("Fast or rapid.");
                _easyHints.Add("To harvest or gather, especially crops.");
                _easyHints.Add("To save someone from danger or harm.");
                _easyHints.Add("An expression of happiness, often shown on the face.");
                _easyHints.Add("A weapon with a long metal blade.");
                _easyHints.Add("A stinging insect often found during the summer.");
            }
            List<string> _AverageHints = new List<string>();
            {
                _AverageHints.Add("A performer skilled in gymnastics and agility.");
                _AverageHints.Add("A step-by-step procedure or formula for solving a problem.");
                _AverageHints.Add("made or produced by human beings rather than occurring naturally, especially as a copy of something natural.");
                _AverageHints.Add("Using unique body characteristics for identification.");
                _AverageHints.Add("Software for accessing the internet.");
                _AverageHints.Add("Sweet, often sugary, food.");
                _AverageHints.Add("Securely encode information.");
                _AverageHints.Add("A barrier to prevent unauthorized access in a network.");
                _AverageHints.Add("Introduce new ideas or methods.");
                _AverageHints.Add("The point of interaction between components or systems.");
                _AverageHints.Add("Global network connecting computers worldwide.");
                _AverageHints.Add("Fair treatment or behavior.");
                _AverageHints.Add("Something difficult or impossible to understand or explain.");
                _AverageHints.Add("A system of interconnected elements.");
                _AverageHints.Add("Strong or intense emotion or feeling.");
                _AverageHints.Add("Agreeable or enjoyable.");
                _AverageHints.Add("An established or official way of doing something.");
                _AverageHints.Add("Writing code for computers.");
                _AverageHints.Add("Programs and operating information used by a computer.");
                _AverageHints.Add("To allow air to circulate in an enclosed area.");
            }
            List<string> _hardHints = new List<string>();
            {
                _hardHints.Add("Computer systems that can perform tasks that typically require human intelligence.");
                _hardHints.Add("Not synchronized in time.");
                _hardHints.Add("Technology that superimposes a computer-generated image on a user's view of the real world.");
                _hardHints.Add("Confirming the validity or truth of something.");
                _hardHints.Add("A digital ledger of transactions.");
                _hardHints.Add("Linking things together in a series or chain.");
                _hardHints.Add("Digital or virtual currency that uses cryptography for security.");
                _hardHints.Add("Measures taken to protect computer systems against unauthorized access or cyberattacks.");
                _hardHints.Add("The interaction of electric currents or fields and magnetic fields.");
                _hardHints.Add("The process of enclosing something in a capsule.");
                _hardHints.Add("The application of scientific and mathematical principles to design and build machines, structures, and more.");
                _hardHints.Add("Creating three-dimensional images using lasers.");
                _hardHints.Add("The branch of mechanics that deals with the mathematical description of the motion and interaction of subatomic particles.");
                _hardHints.Add("Interconnected devices that can collect and exchange data.");
                _hardHints.Add("A subset of AI where systems can learn and improve from experience without explicit programming.");
                _hardHints.Add("Technology manipulating matter on an atomic or molecular scale.");
                _hardHints.Add("Computing utilizing the principles of quantum theory.");
                _hardHints.Add("A process that repeats or refers back to itself.");
                _hardHints.Add("Communication over a distance by cable, telegraph, phone, or broadcasting.");
                _hardHints.Add("Simulated experience created by computer technology.");
            }
            if (listKeyNum == 1)
            {
                return _easyHints[num];
            }
            else if (listKeyNum == 2)
            {
                return _AverageHints[num];
            }
            else if(listKeyNum == 3)
            {
                return _hardHints[num];
            }
            else
            {
                return null;
            }
        }
    }
}

