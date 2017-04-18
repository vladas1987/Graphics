using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl; 

namespace Graphics
{
    class Program
    {
        static void Main(string[] args)
                                             //programos vykdymo pradžia
        {                                                                        //
            Glut.glutInit();                                                     //inicializuojama GLUT aplinka 
            Glut.glutInitDisplayMode(Glut.GLUT_SINGLE | Glut.GLUT_RGB);          //nustatomi vaizdavimo parametrai
            Glut.glutInitWindowSize(400, 400);                                   //nustatomas programos lango dydis 
            Glut.glutInitWindowPosition(400, 300);                               //nustatoma lango pozicija 
            Glut.glutCreateWindow("NIF06020");                                   //sukuriamas langas 
            Init();                                                              //papildomi OpenGL būsenų nustatymai
            Glut.glutDisplayFunc(new Glut.DisplayCallback(Figura));              //vaizdavimo metodo uzregistravimas
            Glut.glutKeyboardFunc(new Glut.KeyboardCallback(Klaviatura1));       //metodo klaviatura1 uzregistravimas
            Glut.glutSpecialFunc(new Glut.SpecialCallback(Klaviatura2));         //metodo klaviatura2 uzregistravimas
            Glut.glutMouseFunc(new Glut.MouseCallback(Pele));                    //metodo pele uzregistravimas
            Glut.glutCreateMenu(new Glut.CreateMenuCallback(Meniu));             //metodo meniu uzregistravimas
            Glut.glutAddMenuEntry("Pirmas punktas", '1');                        //i kontekstini meniu itraukiamas pirmas pasirinkimas
            Glut.glutAddMenuEntry("Antras punktas", '2');                        //i kontekstini meniu itraukiamas antras pasirinkimas                       
            Glut.glutAddMenuEntry("Trecias punktas", '3');                       //i kontekstini meniu itraukiamas trecias pasirinkimas
            Glut.glutAddMenuEntry("Ketvirtas punktas", '4');                     //i kontekstini meniu itraukiamas ketvirtas pasirinkimas   
            Glut.glutAddMenuEntry("Penktas punktas", '5');                       //i kontekstini meniu itraukiamas penktas pasirinkimas
            Glut.glutAddMenuEntry("Progamos pabaiga", '6');                      //i kontekstini meniu itraukiamas sestas pasirinkimas
            Glut.glutAttachMenu(Glut.GLUT_RIGHT_BUTTON);                         //uzregistuojamas iskleidziamas meniu
            Glut.glutMainLoop();                                                 //pradedamas vykdyti grafines programos ciklas
        }                                                                        //
        static void Init()                                                       //                                                        
        {                                                                        //
            Gl.glClearColor(1.0f, 1.0f, 1.0f, 1.0f);                             //nustatoma ekrano isvalymo spalva
            Gl.glColor3f(127 / 256f, 225 / 256f, 0 / 256f);                      //nustatoma piesimo spalva
        }                                                                        //
        static void Figura()                                                     //metodas Figura
        {                                                                        //
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);                                  //isvalomas vaizdavimo buferis
            Gl.glBegin(Gl.GL_TRIANGLE_FAN);                                      //Daugiakampis formuojamas iš trikampių.
            Gl.glVertex3f(0.0f, 0.0f, 0.0f);                                   //virsuniu kordinates
            Gl.glVertex3f(-0.5f, 0.0f, 0.0f);                                   //virsuniu kordinates
            Gl.glVertex3f(-0.3f, 0.1f, 0.0f);                                   //virsuniu kordinates
            Gl.glVertex3f(-0.6f, 0.6f, 0.0f);                                   //virsuniu kordinates
            Gl.glVertex3f(-0.1f, 0.3f, 0.0f);                                   //virsuniu kordinates                                 
            Gl.glVertex3f(0.0f, 0.5f, 0.0f);                                   //virsuniu kordinates
            Gl.glVertex3f(0.1f, 0.3f, 0.0f);                                   //virsuniu kordinates
            Gl.glVertex3f(0.6f, 0.6f, 0.0f);                                   //virsuniu kordinates
            Gl.glVertex3f(0.3f, 0.1f, 0.0f);                                   //virsuniu kordinates
            Gl.glVertex3f(0.5f, 0.0f, 0.0f);                                   //virsuniu kordinates
            Gl.glVertex3f(0.3f, -0.1f, 0.0f);                                   //virsuniu kordinates
            Gl.glVertex3f(0.6f, -0.6f, 0.0f);                                   //virsuniu kordinates
            Gl.glVertex3f(0.1f, -0.3f, 0.0f);                                   //virsuniu kordinates
            Gl.glVertex3f(0.0f, -0.5f, 0.0f);                                   //virsuniu kordinates
            Gl.glVertex3f(-0.1f, -0.3f, 0.0f);                                   //virsuniu kordinates
            Gl.glVertex3f(-0.6f, -0.6f, 0.0f);                                   //virsuniu kordinates
            Gl.glVertex3f(-0.3f, -0.1f, 0.0f);                                   //virsuniu kordinates
            Gl.glVertex3f(-0.5f, 0.0f, 0.0f);                                    //virsuniu kordinates
            Gl.glEnd();                                                          //piesimo pabaiga
            Gl.glFlush();                                                        //vykdomas atvaizdavimas i ekrana
        }                                                                        //
        // *********************** 1 ***********************

        static void Klaviatura1(byte klavisas, int x, int y)                     //metodas klaviatura1
        {                                                                        //
            switch (klavisas)                                                    //galima nustatyti raidiniu klavisu kodus
            {                                                                    //
                case 13:                                                         //nustatomas raidinis klavisas Enter
                    Environment.Exit(0);                                         //uzdaromas programos langas
                    break;                                                       //nutraukiamas pasirinkimas
            }                                                                    //
        }                                                                        //
        // *********************** 2 *********************** 

        static void Klaviatura2(int key, int x, int y)                           //metodas klaviatura2                
        {                                                                        //
            switch (key)                                                         //galima nustatyti visu funkciniu klavisu kodus                           
            {                                                                    //
                case Glut.GLUT_KEY_LEFT:                                         //nustatomas funkcinis klavisas "rodykle i kaire"
                    Environment.Exit(0);                                         //uzdaromas programos langas
                    break;                                                       //nutraukiamas pasirinkimas
            }                                                                    //
        }                                                                        //
                                                                                 // *********************** 3 ************************

        static void Pele(int klavisas, int busena, int x, int y)                //metodas pele
        {                                                                       //
            if ((klavisas == Glut.GLUT_LEFT_BUTTON) & (busena == Glut.GLUT_UP)) //tikrinama ar paspaudziamas kairys peles mygtukas
                Environment.Exit(0);                                            //uzdaromas programos langas
        }                                                                       //
        // *********************** 4-8 *********************

        static void Meniu(int a)                                                //metodas meniu
        {                                                                       //
            switch (a)                                                          //nustatomas pasirinkimas
            {                                                                   //
                case '1':                                                       //pirmas meniu pasirinkimas
                    Gl.glColor3f(127 / 256f, 255 / 256f, 0 / 256f);             //figuros spalvos nustatymas
                    Glut.glutPostRedisplay();                                   //ekrano perpiesimas
                    break;                                                      //pasirinkimo nutraukimas
                case '2':                                                       //antras meniu pasirinkimas          
                    Gl.glColor3f(0 / 256f, 0 / 256f, 139 / 256f);               //figuros spalvos nustatymas
                    Glut.glutPostRedisplay();                                   //ekrano perpiesimas
                    break;                                                      //pasirinkimo nutraukimas
                case '3':                                                       //trecias meniu pasirinkimas 
                    Gl.glClearColor(1.0f, 1f, 1.0f, 1f);                        //fono spalvos nustatymas
                    Glut.glutPostRedisplay();                                   //ekrano perpiesimas           
                    break;                                                      //pasirinkimo nutraukimas
                case '4':                                                       //ketvirtas meniu pasirinkimas
                    Gl.glClearColor(0f, 0f, 0f, 1f);                            //fono spalvos nustatymas
                    Glut.glutPostRedisplay();                                   //ekrano perpiesimas
                    break;                                                      //pasirinkimo nutraukimas
                case '5':                                                       //penktas meniu pasirinkimas
                    Gl.glPolygonMode(Gl.GL_FRONT_AND_BACK, Gl.GL_LINE);         //piesiama neuzspalvinta figura
                    Glut.glutPostRedisplay();                                   //ekrano perpiesimas
                    break;                                                      //pasirinkimo nutraukimas
                case '6':                                                       //sestas meniu pasirinkimas
                    Environment.Exit(0);                                        // uždaromas programos langas 
                    break;                                                      //pasirinkimo nutraukimas
            }                                                                   //
        }                                                                       //
    }                                                                           //
}                                                                               //
