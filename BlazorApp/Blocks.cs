using System;

namespace BlazorApp {

    public class newBlocks {

        public int width;
        public int heigth;
        public int[,] cube;

    }

    public class BlocksShape {

        public static newBlocks[] shapesArray;

        public void BlockShape(){

            shapesArray = new newBlocks[] {
                //Square
                new newBlocks {
                    width = 2,
                    heigth = 2,
                    cube = new int[,] {
                        {1,1},
                        {1,1}
                    },
                },

                // Line
                new newBlocks {
                    width = 4,
                    heigth = 1,
                    cube = new int[,] {
                        {1,1,1,1},
                    },
                },
                new newBlocks {
                    width = 1,
                    heigth = 4,
                    cube = new int[,] {
                        {1},
                        {1},
                        {1},
                        {1}
                    },
                },
                // L-Block
                new newBlocks {
                    width = 3,
                    heigth = 2,
                    cube = new int[,] {
                        {1,0,0},
                        {1,1,1}
                    },
                },
                new newBlocks {
                    width = 2,
                    heigth = 3,
                    cube = new int[,] {
                        {1,1},
                        {1,0},
                        {1,0}
                    },
                },
                new newBlocks {
                    width = 3,
                    heigth = 2,
                    cube = new int[,] {
                        {1,1,1},
                        {0,0,1}
                    },
                },
                new newBlocks {
                    width = 2,
                    heigth = 3,
                    cube = new int[,] {
                        {0,1},
                        {0,1},
                        {1,1}
                    },
                },

                // J-Block
                new newBlocks {
                    width = 3,
                    heigth = 2,
                    cube = new int[,] {
                        {0,0,1},
                        {1,1,1}
                    }
                },
                new newBlocks {
                    width = 2,
                    heigth = 3,
                    cube = new int[,] {
                        {1,1},
                        {0,1},
                        {0,1}
                    }
                },
                new newBlocks {
                    width = 3,
                    heigth = 2,
                    cube = new int[,] {
                        {1,1,1},
                        {1,0,1}
                    }
                },
                new newBlocks {
                    width = 2,
                    heigth = 3,
                    cube = new int[,] {
                        {1,0},
                        {1,0},
                        {1,1}
                    }
                },

                //S-Block 
                new newBlocks {
                    width = 3,
                    heigth = 2,
                    cube = new int[,] {
                        {0,1,1},
                        {1,1,0}
                    },
                },
                new newBlocks {
                    width = 3,
                    heigth = 2,
                    cube = new int[,] {
                        {1,0},
                        {1,1},
                        {0,1}
                    }
                },
               
                // T-Block
                new newBlocks {
                    width = 3,
                    heigth = 2,
                    cube = new int[,] {
                        {0,1,0},
                        {1,1,1}
                    },
                },
                new newBlocks {
                    width = 2,
                    heigth = 3,
                    cube = new int[,] {
                        {1,0},
                        {1,1},
                        {1,0}
                    }
                },
                new newBlocks {
                    width = 3,
                    heigth = 2,
                    cube = new int[,] {
                        {1,1,1},
                        {0,1,0}
                    },
                },
                new newBlocks {
                    width = 2,
                    heigth = 3,
                    cube = new int[,] {
                        {0,1},
                        {1,1},
                        {0,1}
                    }
                },
                // Z-Block
                new newBlocks {
                    width = 3,
                    heigth = 2,
                    cube = new int[,] {
                        {1,1,0},
                        {0,1,1}
                    },
                },
                new newBlocks {
                    width = 2,
                    heigth = 3,
                    cube = new int[,] {
                        {0,1},
                        {1,1},
                        {1,0}
                    }
                },
                
            };
            Console.WriteLine(shapesArray.Length);

        }
        // public static newBlocks RandomShape(){
            
        //     var random = new Random();
            
        //     var randomShape = shapesArray[random.Next(shapesArray.Length)];
            
        //     return randomShape; 
        // }
    }    
}