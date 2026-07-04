#include <iostream>

int main(){
    int n;
    std::cin>>n;
    int arr[n];
    float posi =0, zeno=0, nega=0;

    for(int i=0; i< n; i++){
        std::cin>>arr[i];
        if(arr[i]>0){
            posi++;
        }else if (arr[i]<0)
        {
            nega++;
        }else{
            zeno++;
        }
        
    }
    std::cout<<posi/n<<std::endl
    <<nega/n<<std::endl<<
    zeno/n;

    
    return 0;
}