using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeApp.Classes
{
    public class Cobrinha
    {
        private Rectangle[] _retanguloCobrinha;
        private SolidBrush brushCobrinha;
        private int x, y, altura, largura;

        public Rectangle[] retanguloCobrinha
        {
            get
            {
                return _retanguloCobrinha; 
            }
        }

        public Cobrinha()
        {
            _retanguloCobrinha = new Rectangle[3];
            brushCobrinha = new SolidBrush(Color.Coral);

            x = 30;
            y = 10;

            altura = 15;
            largura = 15;

            for (int i = 0; i < _retanguloCobrinha.Length; i++)
            {
                _retanguloCobrinha[i] = new Rectangle(x, y, altura, largura);
                x -= 10;

            }
        }
        public void desenhaCobrinha(Graphics grafico)
        {
            foreach (Rectangle item in _retanguloCobrinha)
            {
                grafico.FillRectangle(brushCobrinha, item);
            }
        }
        
        public void desenhaCobrinha()
        {
            for (int i = _retanguloCobrinha.Length- 1; i > 0; i--)
            {
                _retanguloCobrinha[i] = _retanguloCobrinha[i - 1];
            }
        }

    }
}
