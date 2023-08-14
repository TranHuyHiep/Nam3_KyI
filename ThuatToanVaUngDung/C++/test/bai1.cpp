#include <Windows.h>
#include <bits/stdc++.h>
int WINAPI WinMain(HINSTANCE hst, HINSTANCE preHst, PSTR cmdLine, int nshow) 
{
	int result;
	do {
		result = MessageBox(NULL, TEXT("Do you want to exit?Yes/No?"), TEXT("Hi"),
			MB_YESNO | MB_ICONQUESTION);
			
	}while(result == IDNO);
	
	
	
	return 0;
}