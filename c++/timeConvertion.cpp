#include <iostream>
#include <string>

int main(){
    std::string str;
    std::cin>>str;

    std::string Shour = str.substr(0,2);
    std::string midTime = str.substr(2, 6);
    std::string day = str.substr(8);

    
    if(day == "PM"){
        if(Shour == "12"){
            std::cout<<Shour<<midTime;
        }else{
            int hour = std::stoi(Shour);
            std::cout<<hour+12<<midTime;
        }
    }
    else{
        if(Shour == "12"){
            std::cout<<"00"<<midTime;
        }else{
            std::cout<<Shour<<midTime;
        }
    }
    
    return 0;
}