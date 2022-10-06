#include <iostream>
#include <array>
  int tope=0, lim=6;
  char pila[6];
void ingresarDatos(){
  std::cout << "Escribe los elementos que desea guardar:\n";
  for(int i=0;i<lim;i++){
    if(pila[i]=='\0'){
      std::cout << "Escribe un valor\n";
      std::cin >> pila[i];tope=i;
      std::cout <<"Escribir otro valor?\n1:Si\n2:N0\n";
      char val; std::cin >>val;
      if(val=='1'){
        if(tope==lim-1){
          std::cout << "Desbordamiento de pila\n";
          break;
        }else{
          continue;
        }
      }else{
         break;
        }
      }else{
        std::cout << "Desbordamiento de pila\n";
      }
    
    }
  }
void vaciarpila(){
  for(int j=0;j<lim;j++){
      pila[j]='\0'; 
    }
  tope=0;
}
  
void SacarDatos(){
  char letra; bool esta=false;
  char otro[lim];
  for(int k=0;k<lim;k++){
      otro[k]=pila[k];
    }  
  std::cout << "Escribe los elemento desea sacar de la pila:\n";
  std::cin >> letra;
  for(int i=lim;i>0;i--){
    if(otro[i]==letra){
      otro[i]='\0';
      esta=true;
      tope=i-1;
      break;
    }
    otro[i]='\0';
  }
  
  if(esta==false){
    std::cout << "No se encuentra tu Caracter en la pila\n";
  }else{
    if(pila[0]==letra){
    vaciarpila();
    esta=true;
    }else{
      for(int j=0;j<lim;j++){
      pila[j]=otro[j];
      }
    }
  }
  
}
void mostrar(){
  std::cout << "\narray = ";
    for (int i = 0; i < lim; ++i) {
        std::cout << "[ " << pila[i] << " ], ";
    }
    std::cout << ";" << std::endl;
  std::cout << "El tope queda en "<< tope <<"\n";
}
int main() {
  bool continuar=true;
  
  
  while(continuar){
    std::cout << "*********MENU**********\n";
    std::cout << "1:Insertar\n";
    std::cout << "2:Sacar\n";
    std::cout << "3:Imprimir\n";
    std::cout << "4:Salir\n";
    int opcion = 0;
    std::cin >> opcion;

    switch(opcion)
    {
    case 1: std::cout << "*********Ingresar**********\n";
      ingresarDatos();
      break;
    case 2: std::cout << "**********Sacar***********\n";
      if(pila[0]=='\0'){
        std::cout << "Subdesbordamiento de pila\nNo hay nada en la pila, ingrese datos\n";
        }else{
          std::cout << "Desea\n1:Sacar un valor de la pila\n2:Vaciar toda la pila\n";
          int hacer;
          std::cin >> hacer;
          if(hacer==1){
            SacarDatos();
          }else if(hacer==2){
            vaciarpila();
          }
        }
      
      
      break;
    case 3: std::cout << "**********Mostrar*********\n";
      mostrar();
      break;
    default: 
      std::cout << "Bye";
      continuar=false;
    }
  }
  
}
