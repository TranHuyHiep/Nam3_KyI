#include<bits/stdc++.h>
using namespace std;

struct node{
	int elem, L, R;		// elem giu max(a[L] ... a[R])
	node *left, *right;	
	// ham tao ra cay
	node(int _L, int _R, node *_left = 0, node *_right = 0){
		L = _L;
		R = _R;
		elem = -INT_MAX;
		if(L < R) {
			left = new node(L, (L + R)/2);
			right = new node((L + R)/2 + 1 , R);
		} 
		else left = right = 0;
	}
};

void update(node *H, int p, int x){
	if(H->elem < x) H->elem = x;
	if(H->left) update(p <= H->left->R ? H->left : H->right, p, x);
}

int get(node *H, int u, int v){
	if(H->L == u && H->R == v) return H->elem;
	if(v <= H->left->R) return get(H->left, u, v);
	if(H->right->L <= u) return get(H->right, u, v);
	return max(get(H->left, u, H->left->R), get(H->right, H->right->L, v));
}

int main(){
	int n, x, u, v, m;
	cin >> n >> m;
	node *H = new node(1, n);
	for(int p = 1; p <= n; p++) {
		cin >> x;
		update(H, p, x);
	}
	while(m--){
		cin >> u >> v;
		cout << get(H, u, v) << "\n";
	}
}
