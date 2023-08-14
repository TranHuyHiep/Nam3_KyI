#include<bits/stdc++.h>
using namespace std;

int main(){
	int n, m, Min = INT_MAX;
	cin >> n >> m;
	int a[m];
	for(int i = 0; i < m; i++){
		cin >> a[i];
	}
	sort(a, a + m);
	for(int i = 0; i < m - n + 1; i++){
		int temp = - a[i] + a[i + n - 1];
		if(Min > temp) Min = temp;
	}
	cout << Min;
}
