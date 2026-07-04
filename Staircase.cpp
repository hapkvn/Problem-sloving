#include <iostream>

int main(){
    int n;
    std::cin>>n;
    int arr[n];

    for(int i=0; i< n; i++){
        for(int j=0; j<n-1-i; j++){
            std::cout<<" ";

        }
        for(int k=0; k<i+1; k++){
            std::cout<<"#";
        }

        std::cout<<std::endl;


    }
    return 0;

}