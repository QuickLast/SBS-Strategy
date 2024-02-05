using MongoDB.Driver;
using SBS_Game.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS_Game.Functions
{
    public class CRUD
    {
        public static void CreateCharacter(Character character)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SBSOsipov");
            var collection = database.GetCollection<Character>("Characters");
            collection.InsertOne(character);
            Console.WriteLine("Character created and added to DB.");
        }

        public static Character GetCharacterByName(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SBSOsipov");
            var collection = database.GetCollection<Character>("Characters");
            var character = collection.Find(x => x.Name == name).FirstOrDefault();
            if (character == null)
            {
                Console.WriteLine("Not Found");
                return null;
            }
            else
            {
                return character;
            }              
        }
    }
}
