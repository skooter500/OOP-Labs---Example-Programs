#include<stdio.h>
#include<string>

using namespace std;

template <typename T, typename S>
S add(T a, T b)
{
	return a + b;
}

void main()
{
	int c = add<int, int>(10, 20);
	printf("%d", c);

	string d = "Hello";
	string e = "world";
	string f = add<string, string>(d, e);

}

