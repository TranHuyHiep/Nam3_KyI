// Truy vấn max dùng mảng
#include<bits/stdc++.h>
using namespace std;
int A[400005];

// A[k] Quan ly [L, R] nhap a[p] = x
void update(int k, int L, int R, int p, int x) {
	if(L == R) {
		A[k] = x;
	} else {
		if(A[k] < x) A[k] = x;
		if(p <= (L + R)/2) update(2*k + 1, L, (L + R)/2, p, x);
		else update(2*k + 2, (L + R)/2 + 1, R, p, x);
		//A[k] = max(A[2*k + 1], A[2*k + 2]);
	}
}

// A[k] quan ly [L, R] can tim max(u, v)
int get(int k, int L, int R, int u, int v){
//	if(u > R || v < L) return -INT_MAX;
//	if(u <= L && R <= v) return A[k];
//	return max(get(2*k + 1, L, (L + R)/2, u, v), get(2*k + 2, (L + R)/2 + 1, R, u, v));

	if(u == L && v == R) return A[k];
	if(u > (L + R)/2) return get(2*k + 2, (L + R)/2 + 1, R, u, v);
	if(v <= (L + R)/2) return get(2*k + 1, L, (L + R)/2, u, v);
	return max(get(2*k + 1, L, (L + R)/2, u, (L + R)/2), get(2*k + 2, (L + R)/2 + 1, R, (L + R)/2 + 1, v));
}

int main(){
	int n, u, v, m;
	cin >> n >> m;
	fill(A, A + 4*n + 1, -INT_MAX);
	for(int i = 1; i <= n; i++) {
		int x;
		cin >> x;
		update(0, 1, n, i, x);
	}
	while(m--){
		cin >> u >> v;
		cout << get(0, 1, n, u, v) << "\n";
	}
	

}
