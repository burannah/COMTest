// Client.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

#import <mscorlib.tlb> raw_interfaces_only
#import <System.Drawing.tlb> raw_interfaces_only
#import "..\Server\bin\Debug\Server.tlb" no_namespace named_guids

int main()
{
	HRESULT hr = CoInitialize(NULL);
	IServer* s = nullptr;
	hr = CoCreateInstance(CLSID_Server,
		NULL, CLSCTX_INPROC_SERVER,
		IID_IServer, reinterpret_cast<void**>(&s));
	auto x = s->GetX();
	System_Drawing::Point pt{ 1,1 };
	s->SetPos(&pt);
	auto p = s->GetX();
	s->Release();
	s = nullptr;

	CoUninitialize();
    return 0;
}

