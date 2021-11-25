namespace BlazorCreate.Data
{
    public class CreateBlocks{
        public static int[,] createBlocks(){

                    int[,] array = new int[4, 4]{{0,0,1,0}, 
                                                {0,0,1,0}, 
                                                {0,0,1,0}, 
                                                {0,0,1,0}};

                    for (int i = 0; i < array.GetLength(0); i++){
                        for ( int j = 0; j < array.GetLength(1); j++){
                                // Console.WriteLine("{0}", array[i, j]);
                        }
                    }
                    // Console.WriteLine();
                    return array;
                }
    }
}