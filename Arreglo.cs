using System;
class Program {
  public static void Main (string[] args) {
    int num,menu=0, tamano=0, t=0;
    Boolean salir=true;
    Console.WriteLine("De que tamano sera el arreglo");
    tamano=int.Parse(Console.ReadLine());
    t=tamano;
    int[] array=new int[t];

    
    while(salir){
    Console.WriteLine("*********MENU***********");
    Console.WriteLine("Modificar el vector");
    Console.WriteLine("1. Altas");
    Console.WriteLine("2. Eliminar");
    Console.WriteLine("3. Buscar");
    Console.WriteLine("4. Ordenar");
    Console.WriteLine("5. Modificar");
    Console.WriteLine("6. Mostrar");
    Console.WriteLine("Salir");
    Console.WriteLine("*********************");
    
    num=int.Parse(Console.ReadLine());
    menu=num;
          
    switch(menu){
      case 1:
        Console.WriteLine("GUARDAR UN ELEMENTO \n Escribe los elementos para guaradar ");
        for (int i = 0; i < array.Length; i++) {
          if(array[i]==0){
            Console.WriteLine(" Escribe un valor");
            array[i]=int.Parse(Console.ReadLine());
            
            Console.WriteLine(" Escribir otro valor, si o no?");
            String val=Console.ReadLine();
            if(val.Equals("no")){
              break;
            }else{
              continue;
            }
          }
        }
        break;
        
      case 2:
        if(array[0]==0){
          Console.WriteLine(" El arreglo está vacío!\n");
          break;
        }else{
          Console.WriteLine("ELIMINAR UN ELEMENTO");
          Console.WriteLine(" 1:Eliminar todo el arreglo \n 2:Eliminar un valor");
          int eliminar=int.Parse(Console.ReadLine());
          if(eliminar==1){
            array=MetodoEliminar(array);
          }else{
            Console.WriteLine(" Que numero desea eliminar?");
            int n=int.Parse(Console.ReadLine());
            int ind=MetodoBuscar(array,n);
            if(ind<0){
              break;
            }else{
              array=MetodoRecorrer(array,ind,t);
            }
          }
        }  
        break;
        
      case 3:
        if(array[0]==0){
          Console.WriteLine("El arreglo está vacío!\n");
          break;
        }else{
          Console.WriteLine("BUSCAR ELEMENTO \n Que numero desea encontrar?");
          int o=int.Parse(Console.ReadLine());
          int id=MetodoBuscar(array,o);
          Console.WriteLine(" El numero que busca esta en el indice "+id);
        }
        break;
        
      case 4: 
        Console.WriteLine("ORDENAR ELEMENTOS \n Como desea ordener los elementos? \n 1:Ascendente \n 2:Descendente");
        int m=int.Parse(Console.ReadLine());
        array=MetodoOrdenar(array,m);  
        break;

      case 5:
        if(array[0]==0){
          Console.WriteLine(" El arreglo está vacío!\n");
          break;
        }else{
          Console.WriteLine("MODIFICAR ELEMENTO \n Que numero desea modificar?");
          int o=int.Parse(Console.ReadLine());
          int id=MetodoBuscar(array,o);
          if(id>0){
            array=MetodoModificar(array,id);
          }
        }
        break;
        
      case 6:
          Console.WriteLine("********************");
          for (int j = 0; j < array.Length; j++){
            Console.Write("["+array[j]+"]"+" ");
            Console.WriteLine();
          }
          break;
        
      default:
        salir=false;
        Console.WriteLine("Fin");
        break;
      }  
    }
  }

    private static int[] MetodoRecorrer(int[] array, int pos, int tam){
      int[] resultado=new int[tam];
      for (int i = 0; i < array.Length-1; i++) {
        if(i>=pos){
          resultado[i] = array[i + 1];
        }else{
          resultado[i] = array[i];
        }
      }
      return resultado;
    }
    private static int MetodoBuscar(int[] array, int numero){
      int indice=-1;
      for (int i = 0; i < array.Length; i++){         
        if (array[i] == numero){
          indice=i;
        } 
      }
      if(indice==-1){
        Console.WriteLine(" El valor que busca no esta en el arreglo");
      }
      return indice; 
    }
    private static int[] MetodoOrdenar(int[] orden,int val){
      if(val==1){
       Array.Sort(orden); 
      }else{
        Array.Reverse(orden);
      }
      return orden;
    }
  private static int[] MetodoModificar(int[] mod,int i){
    Console.WriteLine(" Por que valor desea modificarlo?");
    int val=int.Parse(Console.ReadLine());
    mod[i]=val;
    return mod;
  }
  private static int[] MetodoEliminar(int[] eli){
    for(int k=0;k<eli.Length;k++){
      eli[k]=0;
    }
    return eli;
  }
  private static Boolean MetodoVerificar(int[] arr){
    int cons=arr.Length,cont=0; Boolean b=false;
    for(int i=0;i<arr.Length;i++){
      if(arr[i]==0){
        cont++;
      }
    }
    if(cons==cont){
      b=true;
    }
    return b;
  }
}
