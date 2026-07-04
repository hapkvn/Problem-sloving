#include <iostream>

int main(){
    int n;
    std::cin>>n;
    int arr[n][n];
    int sum1=0, sum2=0;
    for(int i=0; i<n; i++){
        for(int j=0; j<n; j++){
            std::cin>>arr[i][j];
        }
    }
    for(int i=0; i<n; i++){
       sum1+=arr[n-1-i][i];       
        sum2+=arr[i][i];       
        
    }
    int sum = sum2-sum1;
    std::cout<<abs(sum);
    



    return 0;
}