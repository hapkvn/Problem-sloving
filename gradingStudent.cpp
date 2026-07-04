#include <iostream>
#include <vector>


int main(){
    int n; 
    std::cin>>n;

    std::vector<int> arr(n);

    for(int i=0; i<n; i++){
        std::cin>>arr[i];

    }

    for(int i=0; i<n; i++){
        if(arr[i]>37){
            int find = arr[i]%5;
            if(find>=3){

                arr[i] = arr[i] + (5-find);
            }
        }
        std::cout<<arr[i]<<std::endl;
    }
    return 0;
}