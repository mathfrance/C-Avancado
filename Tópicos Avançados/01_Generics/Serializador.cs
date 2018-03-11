using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace Tópicos_Avançados
{
    public class Serializador 
    {
        public static void Serializar(Object obj)
        {
            StreamWriter sWriter = new StreamWriter(@"C:\Users\matheus.pinheiro\Documents\Visual Studio 2010\Projects\C# Avançado\Tópicos Avançados\01_Generics\03_"+ obj.GetType().Name +".txt");
            string ObjetoSerializado = JsonConvert.SerializeObject(obj);

            sWriter.Write(ObjetoSerializado);
            sWriter.Close();
        }

        public static T Deserializar<T>()
        {
            StreamReader sReader = new StreamReader(@"C:\Users\matheus.pinheiro\Documents\Visual Studio 2010\Projects\C# Avançado\Tópicos Avançados\01_Generics\03_"+ typeof(T).Name +".txt");
            string Conteudo = sReader.ReadToEnd();
            T obj = (T)JsonConvert.DeserializeObject(Conteudo, typeof(T));
            return obj;
        }
    }
}
