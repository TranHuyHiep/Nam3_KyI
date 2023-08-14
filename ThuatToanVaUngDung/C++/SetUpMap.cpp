#include<bits/stdc++.h>
using namespace std;

template<class K, class V>
struct node{
	pair<K, V> elem;
	node *left, *right;
	node(K k, V v, node *L = 0, node *R = 0){
		elem = {k, v};
		left = L;
		right = R;
	}
};

template<class K, class V>
bool insert(node *&H, K k,  V v){
	if(!H) {
		H = new node<K, V>(k, v);
		return true;
	} 
	if(H->elem.first == k) {
		H->elem.second = v;
		return false;
	}
	
	if(k < H->elem.first) {
		return insert(H->left, k , v);
	}
	return insert(H->right, k, v);
}

template<class K, class V>
node<K, V> *find(node<K, V> *&H, K k) {
	if(!H or H->elem.first == k) {
		return H;
	}
	if(k < H->elem.first) {
		return find(H->left, k);
	}
	return find(H->right, k);
}

template<class K, class V>
void inorder(node<K, V>* H, list<node<K, V>*> &L) {
	if(!H) return;
	inorder(H->left, L);
	L.push_back(H);
	inorder(H->right, L);
}

template<class K, class V>
class Map_ite{
	list<node<K, V> *> L;
	public:
		Map_ite(node<K, V> *H)
		{
			L = NULL;
			inorder(H, L);
		} 
		list<node<K, V> *> &get_ite() {
			return L;
		}
};

template<class K, class V>
class Map{
	node *root = 0;
	int n;
	Map() {
		root = NULL;
		n = 0;
		int size() {
			return n;
		}
		bool empty() {
			return n == 0;
		}
		V &operator[](K k){
			node<K, V> *p = find(root, k);
			if(p != NULL) return p->elem.second;
			else {
				n++;
				V v;
				insert(root, k, v);
			}	
		}
		typedef Map_ite<K, P> iterator;
		iterator begin() {
			
		}
	}
};

int main(){

}
