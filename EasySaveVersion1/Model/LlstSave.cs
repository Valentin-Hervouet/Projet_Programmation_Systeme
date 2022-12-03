using System;
using System.IO;

namespace EasySaveVersion1.Model
{
	public class ListSave
	{
        private string path = "/Users/emili/Source/Repos/Projet_Programmation_Systeme/EasySaveVersion1/json/Sample_state.json";

        public string listsave()
		{

            string json2 = File.ReadAllText(path);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json2);
            
			if (jsonObj.Count == 0)
			{
				return "no current save create a save with: creatsave";
			}else{
				string toreturn = "";
				foreach (var save in jsonObj)
				{
					toreturn += save.Name + "\n";
                }	
				return toreturn;
			}
		}
	}
}

