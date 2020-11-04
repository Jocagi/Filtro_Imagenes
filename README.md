# Proyecto de Algebra Lineal
Universidad Rafel Landívar 2020

<a href="https://imgur.com/WuBMIqZ"><img src="https://i.imgur.com/WuBMIqZ.png" title="source: imgur.com" /></a>
<a href="https://imgur.com/Vs4gm7Z"><img src="https://i.imgur.com/Vs4gm7Z.png" title="source: imgur.com" /></a>

El proyecto del curso de Álgebra Lineal consiste en elaborar un programa de edición de imágenes por medio de filtros digitales. Este fue realizado en el lenguaje de programación: C#
Para la implementación del proyecto se utilizaron matrices convolutivas de 3X3 e imágenes de cualquier tamaño y color. 
Los filtros que deben de ser aplicados con sus respectivas matrices convolutivas o kernel las cuales son presentadas a continuación.

Original =        { 0, 0, 0 } 
                  { 0, 1, 0 } 
                  { 0, 0, 0 } 

Difuminado =  {0.0625f, 0.125f, 0.0625f} 
              {0.125f,  0.25f,  0.125f } 
              {0.0625f, 0.125f, 0.0625f}
             
Realzar =       { -2, -1, 0 } 
                { -1,  1, 1 } 
                {  0,  1, 2 }
             
Sobel_Inferior =  { -1, -2, -1 } 
                  {  0,  0,  0 } 
                  {  1,  2,  1 }
                  
Sobel_Superior =  {  1,  2,  1 } 
                  {  0,  0,  0 } 
                  { -1, -2, -1 } 
                  
Sobel_Izquierdo = { 1, 0, -1 } 
                  { 2, 0, -2 } 
                  { 1, 0, -1 } 
                  
Sobel_Derecho =   { -1, 0, 1 } 
                  { -2, 0, 2 } 
                  { -1, 0, 1 }
                  
Contorno =        { -1, -1, -1 } 
                  { -1,  8, -1 } 
                  { -1, -1, -1 }
                  
Afilar =          {  0, -1,  0 } 
                  { -1,  5, -1 } 
                  {  0, -1,  0 }
                  
                  
Referencias:
1. http://setosa.io/ev/image-kernels/
2. http://docs.gimp.org/en/plug-in-convmatrix.html
        
