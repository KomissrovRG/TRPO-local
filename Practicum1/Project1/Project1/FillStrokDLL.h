#pragma once

#ifdef FILLSTROKDLL_EXPORTS
#define FILLSTROKDLL_API __declspec(dllexport)
#else
#define FILLSTROKDLL_API __declspec(dllimport)
#endif

extern "C" FILLSTROKDLL_API char fill(int*);
