#include <iostream>
#include <list>
#include <sstream>
#include <SFML/Graphics.hpp>
#include "sftext.h"

using namespace std;

struct Ambiente{
    list<char> texto;
    list<char>::iterator cursor;
    Ambiente(){
        cursor = texto.end();
    }
    string toString(){
        stringstream ss;
        for(auto it = texto.begin(); it != texto.end(); it++){
            if(it == cursor)
                ss << "#";
            ss << (*it);
            return ss.str();
        }
    }
};


int main()
{
   Ambiente amb;
   amb.texto.push_back('a');
   amb.texto.push_back('m');
   amb.texto.push_back('o');
   amb.texto.push_back('r');

   sf::RenderWindow janela(sf::VideoMode(800,600), "Janela");

   while (janela.isOpen()) {
       sf::Event event;
       while (janela.pollEvent(event)) {
           if(event.type == sf::Event::Closed){
               janela.close();
           }
           if(event.type == sf::Event::KeyPressed){
               if(event.key.code == sf::Keyboard::Z){
                    if(event.key.control){
                        cout << "control z" << endl;
                    }
               }
               else if((event.key.code >= sf::Keyboard::A) && event.key.code <= sf::Keyboard::Z){
                   char tecla = (event.key.code - sf::Keyboard::A) + 'a';
                   cout << tecla << endl;
                   amb.texto.insert(amb.cursor, tecla);
               }
               else if(event.key.code == sf::Keyboard::Space){
                   cout << "espaco" << endl;
                   amb.texto.insert(amb.cursor, ' ');
               }
               else if(event.key.code == sf::Keyboard::BackSpace){
                   cout << "backspace" << endl;
               }
               else if(event.key.code == sf::Keyboard::Delete){
                   cout << "delete" << endl;
               }
               else if(event.key.code == sf::Keyboard::Left){
                   amb.cursor--;
               }
               else if(event.key.code == sf::Keyboard::Right){
                   amb.cursor++;
               }
           }
       }
       auto pos = sf::Vector2f(30, 50);
       janela.clear();
       janela.draw(sfText(pos, amb.toString(), sf::Color::White, 30));
       janela.display();
   }
   return 0;
}
