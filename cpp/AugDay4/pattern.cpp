#include<iostream>
using namespace std;
int main(){
int row;
cin>>row;

 for (int i =row; i >= 1; --i) {
      
        for (int j = 0; j < (row - i); ++j) {
            cout << " ";
        }
       
        for (int k = 0; k < (2 * i - 1); ++k) {
            cout << "*";
        }
        cout <<endl; 
    }
     

}