#include <iostream>

int main(){
    long n;
    std::cin>>n;
    long arr[n];
    long sum=0;
    for(int i=0; i<n; i++){
        std::cin>>arr[i];
        sum+=arr[i];
    }
    std::cout<<sum;
    return 0;
}