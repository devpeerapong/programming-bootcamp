#include <iostream>
using namespace std;
void main()
{
	cout << "Enter the number of multiplication table: ";
	int number = 0;
	cin >> number;
	
	if (number < 0 || number > 12) {
		cout << "The number must be between 1 - 12";
	}
	else {
		for (int i = 1; i < 13; i++) {
			int result = number * i;
			cout << number << " x " << i << " = " << result << endl;
		}
	}
	system("pause");
}