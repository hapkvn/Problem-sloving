#include <iostream>

int main(){
   
    int a[3], b[3];
    int pb=0, pa =0;
    for(int i=0; i<3; i++){
        std::cin>>a[i];
    }
    for(int i=0; i<3; i++){
        std::cin>>b[i];
    }

    for(int i=0; i<3; i++){
        if(a[i]>b[i]){
            pa++;
        }
        if(b[i]>a[i]){
            pb++;
        }
    }

    std::cout<<pa <<" "<<pb;
    return 0;

}

