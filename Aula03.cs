using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula03{




       
       
      

    static void Main(String[] args){
    int i = 0;
    string nome = "";
       string eml = "";
        string tel = "";
        string rg = "";
        string op = "";
       string caminho = "usuario.txt";
       StreamWriter sw = new StreamWriter(caminho, true);
   Console.WriteLine("----------------------------------");
      Console.WriteLine("##########################");
      Console.WriteLine("##########################");
      Console.WriteLine("########## DIGITE G PRA GRAVAR");
      Console.WriteLine("########## DIGITE L PRA LER");
      Console.WriteLine("D - Deletar ###################");
      Console.WriteLine("########## DIGITE S PRA SAIR");
      Console.WriteLine("##########################");
      Console.WriteLine("##########################");
      Console.Write("Digite uma operação: ");
      op = Console.ReadLine().ToUpper();

      while(op != "S"){

      if(op == "G"){

         Console.WriteLine("Nome: ");
         nome = Console.ReadLine();
        Console.WriteLine("E-mail: ");
         eml = Console.ReadLine();
        Console.WriteLine("RG: ");
         rg = Console.ReadLine();
        Console.WriteLine("Telefone: ");
        tel = Console.ReadLine();

      

      sw.WriteLine("Nome: {0} ",nome);
      sw.WriteLine("E-mail: {0} ",eml);
      sw.WriteLine("RG: {0} ",rg);
      sw.WriteLine("Telefone: {0} ",tel);
    sw.Close();
      
      
      }
      else if(op == "L"){
        if(i < 1){
         StreamReader sr = new StreamReader(caminho);
         while(sr.EndOfStream != true){
         Console.WriteLine(sr.ReadLine());
         }
         sr.Close();
        }else{
            Console.WriteLine("Lista Vazia");

        }
        
         
         
      }else if( op == "D"){
         
    File.Delete("usuario.txt");
    i = 1;
    
        
      
       
      }


                Console.WriteLine();
                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();
 
                Console.Clear();
                Console.WriteLine("----------------------------------");
          Console.WriteLine("##########################");
          Console.WriteLine("##########################");
          Console.WriteLine("########## DIGITE G PRA GRAVAR");
          Console.WriteLine("########## DIGITE L PRA LER");
          Console.WriteLine("D - Deletar ###################");
          Console.WriteLine("########## DIGITE S PRA SAIR");
          Console.WriteLine("##########################");
          Console.WriteLine("##########################");
                Console.Write("Digite uma operação: ");
 
                op = Console.ReadLine().ToUpper();
                Console.WriteLine();


      
       
        
        




      }

        
    } 

   
       
       

 





}