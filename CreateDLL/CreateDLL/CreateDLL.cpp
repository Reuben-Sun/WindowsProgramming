#include <iostream>
#include "pch.h"
#include "CreateDLL.h"

int __stdcall factorial(int a) {
	int ans = 1;
	for (int i = 1; i <= a; i++) {
		ans *= i;
	}
	return ans;
}

int __stdcall sub(int x, int y) {
	if (x >= y) {
		return x - y;
	}
	else {
		return y - x;
	}
}