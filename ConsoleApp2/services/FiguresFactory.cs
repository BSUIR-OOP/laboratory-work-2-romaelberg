using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp2.services
{
    public class FiguresFactory {
        private string figureType { get;set };
        public FiguresFactory(string figureType) {
            this.figureType = figureType;
        }
        public Circle getCircle() {
            
        }
    }
}