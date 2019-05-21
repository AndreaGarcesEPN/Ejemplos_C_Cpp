#include <iostream>
#include <string.h>
using std::cin;
using std::cout;
using std::endl;

void Foo() {
	cout << "Hello World!" << endl;
}

int main(int argc, char** argv) {
	
	string input = '\n'; 
	cout << "Hello! This is a console application." << endl;
	cout << "Press q to quit, press a to execute foo." << endl;	
	while(1) {
		cin >> input;
		if((input == 'a') || (input == 'A') ) {
			Foo();
		} else if(input == 'q') {
			break;
		} else if(input != '\n') {
			cout << "Unknown command '" << input << "'! Ignoring...\n";
		}
	}

	return 0;
}
