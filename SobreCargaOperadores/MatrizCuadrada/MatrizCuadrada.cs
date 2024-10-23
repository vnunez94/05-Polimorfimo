public class MatrizCuadra{
    private int n;
    private int[,] matriz;
    //constructor 
    public MatrizCuadra(int n){
        this.n = n;
        matriz = new int[n,n];
    }
    //constructor
    public MatrizCuadra(int[,] a){
        n = a.GetLength(0);
        matriz = new int[n,n];
        AgregarRango(a);
    }

    public override string ToString(){
        string s = "";
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                s += matriz[i,j] + " ";
            }
            s += "\n";
        }
        return s;
    }

    public void AgregarRango(int[,] a){
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n; j++){
                matriz[i,j] = a[i,j];
            }
        }
    }

 
    public static MatrizCuadra operator +(MatrizCuadra a, MatrizCuadra b){
        MatrizCuadra c = new MatrizCuadra(a.n);
        for(int i = 0; i < a.n; i++){
            for(int j = 0; j < a.n; j++){
                c.matriz[i,j] = a.matriz[i,j] + b.matriz[i,j];
            }
        }
        return c;
    }

    public static MatrizCuadra operator -(MatrizCuadra a, MatrizCuadra b){
        MatrizCuadra c = new MatrizCuadra(a.n);
        for(int i = 0; i < a.n; i++){
            for(int j = 0; j < a.n; j++){
                c.matriz[i,j] = a.matriz[i,j] - b.matriz[i,j];
            }
        }
        return c;
    }  
    
    public static MatrizCuadra operator *(MatrizCuadra a, MatrizCuadra b){
        MatrizCuadra c = new MatrizCuadra(a.n);
        for(int i = 0; i < a.n; i++){
            for(int j = 0; j < a.n; j++){
                c.matriz[i,j] = 0;
                for(int k = 0; k < a.n; k++){
                    c.matriz[i,j] += a.matriz[i,k] * b.matriz[k,j];
                }
            }
        }
        return c;
    }


}