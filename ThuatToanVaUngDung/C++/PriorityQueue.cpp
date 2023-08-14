#include<bits/stdc++.h>
using namespace std;

template<class T, class CMP = less<T>>
class PQ
{
	private: 
		int n, cap;
		T *buf;
		CMP ss;
		void Heapy_dow(int k)
		{
			if(2*k + 1 >= n) return;
			int p = 2*k+1;
			if(p + 1 < n && ss(buf[p + 1], buf[p])) p++;
			if(ss(buf[k], buf[p])) {
				swap(buf[k], buf[p]);
				Heapy_dow(p);
			}
		}
	public:
		PQ(){
			n = cap = 0;
			buf = nullptr;
		}
		
		~PQ(){
			if(buf) delete[]buf;
		}
		bool empty() {
			return n == 0;
		}
		int size(){
			return n;
		}
		T top(){
			return buf[0];
		}
		void pop(){
			buf[0] = buf[--n];
			Heapy_dow(0);
		}
		void push(T x){
			if(n == cap) {
				cap = cap ? cap * 2 : 1;
				T *tem = new T[cap];
				for(int i = 0; i < n; i++) {
					tem[i] = buf[i];
				}
				if(buf) delete []buf;
				buf = tem;
			}
			buf[n++] = x;
			int k = n - 1;
			while(k > 0 && ss(buf[(k - 1)/2], buf[k])) {
				swap(buf[(k - 1)/2], buf[k]);
				k = (k - 1)/2;
			}
		}
};

int main(){
	PQ<int> Q;
	for(int x : {231,23,123,123,12,3,235,5,63,24,1223}) Q.push(x);
	while(Q.size()) 
	{
		cout << Q.top() << " ";
 		Q.pop();
	}
}
