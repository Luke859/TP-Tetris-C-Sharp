using System;

namespace BlazorApp.Data {

    public class Block {

        public int width;
        public int heigth;
        public int[,] pieces;

    }

    public class BlocksShape {

        public Block[] shapesArray;

        public int[,] array; 

        public Block[] BlockShape(){

            shapesArray = new Block[] {
                //Square
                new Block {
                    width = 2,
                    heigth = 2,
                    pieces = new int[,] {
                        {1,1},
                        {1,1}
                    },
                },
                // Line
                new Block {
                    width = 4,
                    heigth = 1,
                    pieces = new int[,] {
                        {2,2,2,2},
                    },
                },
                
                new Block {
                    width = 1,
                    heigth = 4,
                    pieces = new int[,] {
                        {2},
                        {2},
                        {2},
                        {2}
                    },
                },
                // L-Block
                new Block {
                    width = 3,
                    heigth = 2,
                    pieces = new int[,] {
                        {3,0,0},
                        {3,3,3}
                    },
                },
                new Block {
                    width = 2,
                    heigth = 3,
                    pieces = new int[,] {
                        {3,3},
                        {3,0},
                        {3,0}
                    },
                },
                new Block {
                    width = 3,
                    heigth = 2,
                    pieces = new int[,] {
                        {3,3,3},
                        {0,0,3}
                    },
                },
                new Block {
                    width = 2,
                    heigth = 3,
                    pieces = new int[,] {
                        {0,3},
                        {0,3},
                        {3,3}
                    },
                },

                // J-Block
                new Block {
                    width = 3,
                    heigth = 2,
                    pieces = new int[,] {
                        {0,0,4},
                        {4,4,4}
                    }
                },
                new Block {
                    width = 2,
                    heigth = 3,
                    pieces = new int[,] {
                        {4,0},
                        {4,0},
                        {4,4}
                    }
                },
                new Block {
                    width = 3,
                    heigth = 2,
                    pieces = new int[,] {
                        {4,4,4},
                        {4,0,0}
                    }
                },
                new Block {
                    width = 2,
                    heigth = 3,
                    pieces = new int[,] {
                        {4,4},
                        {0,4},
                        {0,4}
                    }
                },

                //S-Block 
                new Block {
                    width = 3,
                    heigth = 2,
                    pieces = new int[,] {
                        {0,5,5},
                        {5,5,0}
                    },
                },
                new Block {
                    width = 3,
                    heigth = 2,
                    pieces = new int[,] {
                        {5,0},
                        {5,5},
                        {0,5}
                    }
                },
               
                // T-Block
                new Block {
                    width = 3,
                    heigth = 2,
                    pieces = new int[,] {
                        {0,6,0},
                        {6,6,6}
                    },
                },
                new Block {
                    width = 2,
                    heigth = 3,
                    pieces = new int[,] {
                        {6,0},
                        {6,6},
                        {6,0}
                    }
                },
                new Block {
                    width = 3,
                    heigth = 2,
                    pieces = new int[,] {
                        {6,6,6},
                        {0,6,0}
                    },
                },
                new Block {
                    width = 2,
                    heigth = 3,
                    pieces = new int[,] {
                        {0,6},
                        {6,6},
                        {0,6}
                    }
                },
                // Z-Block
                new Block {
                    width = 3,
                    heigth = 2,
                    pieces = new int[,] {
                        {7,7,0},
                        {0,7,7}
                    },
                },
                new Block {
                    width = 2,
                    heigth = 3,
                    pieces = new int[,] {
                        {0,7},
                        {7,7},
                        {7,0}
                    }
                },
            };  
            return shapesArray;         
        }

        public int randomInt(){
            
            var random = new Random();
            var randomShape = random.Next(shapesArray.Length);
            
            return randomShape; 
        }
    
        public int[,] DisplayRandom(Block[] array){

            int random = randomInt();

            return array[random].pieces;
        }       
    }    
}