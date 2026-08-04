#include <iostream>
int main(){
    
    long long arr[5];
   

    for(int i=0; i<5 ; i++){
        std::cin>>arr[i];
    }

    
    long long sum=0;
    for(int i=0; i<5; i++){
        sum += arr[i];
        
    }

    long long max = arr[0];
    long long min = sum;

    long long arrM[5];
    for(int i=0; i<5; i++){
        arrM[i] = sum-arr[i];

        if(min >= arrM[i]){
            min = arrM[i];
        }
        if(max <= arrM[i]){
            max = arrM[i];
        }
    }
    

    

    std::cout<<min<<" "<<max;
    return 0;
}