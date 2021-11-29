using System;
using System.Collections.Generic;

namespace BlazorApp {

    public class newBlocks {

        public int width;
        public int heigth;
        public int[,] pieces;

    }

    public class BlocksShape {

        public static newBlocks[] shapesArray;

        public void BlockShape(){

            shapesArray = new newBlocks[] {
                //Square
                new newBlocks {
                    width = 2,
                    heigth = 2,
                    pieces = new int[,] {
                        {1,1},
                        {1,1}
                    },
                },
                // Line
                new newBlocks {
                    width = 4,
                    heigth = 1,
                    pieces = new int[,] {
                        {2,2,2,2},
                    },
                },
                
                new newBlocks {
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
                new newBlocks {
                    width = 3,
                    heigth = 2,
                    pieces = new int[,] {
                        {3,0,0},
                        {3,3,3}
                    },
                },
                new newBlocks {
                    width = 2,
                    heigth = 3,
                    pieces = new int[,] {
                        {3,3},
                        {3,0},
                        {3,0}
                    },
                },
                new newBlocks {
                    width = 3,
                    heigth = 2,
                    pieces = new int[,] {
                        {3,3,3},
                        {0,0,3}
                    },
                },
                new newBlocks {
                    width = 2,
                    heigth = 3,
                    pieces = new int[,] {
                        {0,3},
                        {0,3},
                        {3,3}
                    },
                },

                // J-Block
                new newBlocks {
                    width = 3,
                    heigth = 2,
                    pieces = new int[,] {
                        {0,0,4},
                        {4,4,4}
                    }
                },
                new newBlocks {
                    width = 2,
                    heigth = 3,
                    pieces = new int[,] {
                        {4,0},
                        {4,0},
                        {4,4}
                    }
                },
                new newBlocks {
                    width = 3,
                    heigth = 2,
                    pieces = new int[,] {
                        {4,4,4},
                        {4,0,0}
                    }
                },
                new newBlocks {
                    width = 2,
                    heigth = 3,
                    pieces = new int[,] {
                        {4,4},
                        {0,4},
                        {0,4}
                    }
                },

                //S-Block 
                new newBlocks {
                    width = 3,
                    heigth = 2,
                    pieces = new int[,] {
                        {0,5,5},
                        {5,5,0}
                    },
                },
                new newBlocks {
                    width = 3,
                    heigth = 2,
                    pieces = new int[,] {
                        {5,0},
                        {5,5},
                        {0,5}
                    }
                },
               
                // T-Block
                new newBlocks {
                    width = 3,
                    heigth = 2,
                    pieces = new int[,] {
                        {0,6,0},
                        {6,6,6}
                    },
                },
                new newBlocks {
                    width = 2,
                    heigth = 3,
                    pieces = new int[,] {
                        {6,0},
                        {6,6},
                        {6,0}
                    }
                },
                new newBlocks {
                    width = 3,
                    heigth = 2,
                    pieces = new int[,] {
                        {6,6,6},
                        {0,6,0}
                    },
                },
                new newBlocks {
                    width = 2,
                    heigth = 3,
                    pieces = new int[,] {
                        {0,6},
                        {6,6},
                        {0,6}
                    }
                },
                // Z-Block
                new newBlocks {
                    width = 3,
                    heigth = 2,
                    pieces = new int[,] {
                        {7,7,0},
                        {0,7,7}
                    },
                },
                new newBlocks {
                    width = 2,
                    heigth = 3,
                    pieces = new int[,] {
                        {0,7},
                        {7,7},
                        {7,0}
                    }
                },
            };
            
        }

        public static int randomInt(){
            
            var random = new Random();
            
            // var randomInt = shapesArray[random]
            var randomShape = random.Next(shapesArray.Length);
            
            return randomShape; 
        }

        public static int[] DisplayRandom(){

            

            for (int i = 0; i < shapesArray[randomInt()].heigth; i++){
                for (int j = 0; j < shapesArray[randomInt()].width; j++){
                    Console.Write(shapesArray[randomInt()].pieces[i, j]); 
                }
               Console.WriteLine();
            };


        }
    }    
}