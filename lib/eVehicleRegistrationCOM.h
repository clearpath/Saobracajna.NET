

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 7.00.0500 */
/* at Mon Aug 08 13:25:57 2011
 */
/* Compiler settings for .\vehicleCOM.idl:
    Oicf, W1, Zp8, env=Win32 (32b run)
    protocol : dce , ms_ext, c_ext
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
//@@MIDL_FILE_HEADING(  )

#pragma warning( disable: 4049 )  /* more than 64k source lines */


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 440
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __VehicleCOM_h__
#define __VehicleCOM_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

#ifndef __IRegistration_FWD_DEFINED__
#define __IRegistration_FWD_DEFINED__
typedef interface IRegistration IRegistration;
#endif 	/* __IRegistration_FWD_DEFINED__ */


#ifndef __Registration_FWD_DEFINED__
#define __Registration_FWD_DEFINED__

#ifdef __cplusplus
typedef class Registration Registration;
#else
typedef struct Registration Registration;
#endif /* __cplusplus */

#endif 	/* __Registration_FWD_DEFINED__ */


/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"

#ifdef __cplusplus
extern "C"{
#endif 


/* interface __MIDL_itf_vehicleCOM_0000_0000 */
/* [local] */ 

typedef struct _REGISTRATION_DATA
    {
    VARIANT registrationData;
    VARIANT signatureData;
    VARIANT issuingAuthority;
    } 	REGISTRATION_DATA;

typedef struct _DOCUMENT_DATA
    {
    BSTR stateIssuing;
    BSTR competentAuthority;
    BSTR authorityIssuing;
    BSTR unambiguousNumber;
    BSTR issuingDate;
    BSTR expiryDate;
    BSTR serialNumber;
    } 	DOCUMENT_DATA;

typedef struct _VEHICLE_DATA
    {
    BSTR dateOfFirstRegistration;
    BSTR yearOfProduction;
    BSTR vehicleMake;
    BSTR vehicleType;
    BSTR commercialDescription;
    BSTR vehicleIDNumber;
    BSTR registrationNumberOfVehicle;
    BSTR maximumNetPower;
    BSTR engineCapacity;
    BSTR typeOfFuel;
    BSTR powerWeightRatio;
    BSTR vehicleMass;
    BSTR maximumPermissibleLadenMass;
    BSTR typeApprovalNumber;
    BSTR numberOfSeats;
    BSTR numberOfStandingPlaces;
    BSTR engineIDNumber;
    BSTR numberOfAxles;
    BSTR vehicleCategory;
    BSTR colourOfVehicle;
    BSTR restrictionToChangeOwner;
    BSTR vehicleLoad;
    } 	VEHICLE_DATA;

typedef struct _PERSONAL_DATA
    {
    BSTR ownersPersonalNo;
    BSTR ownersSurnameOrBusinessName;
    BSTR ownerName;
    BSTR ownerAddress;
    BSTR usersPersonalNo;
    BSTR usersSurnameOrBusinessName;
    BSTR usersName;
    BSTR usersAddress;
    } 	PERSONAL_DATA;



extern RPC_IF_HANDLE __MIDL_itf_vehicleCOM_0000_0000_v0_0_c_ifspec;
extern RPC_IF_HANDLE __MIDL_itf_vehicleCOM_0000_0000_v0_0_s_ifspec;

#ifndef __IRegistration_INTERFACE_DEFINED__
#define __IRegistration_INTERFACE_DEFINED__

/* interface IRegistration */
/* [unique][helpstring][uuid][dual][object] */ 


EXTERN_C const IID IID_IRegistration;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("0BE1D001-A538-476B-8F59-6594741D7720")
    IRegistration : public IUnknown
    {
    public:
        virtual /* [source][helpstring] */ HRESULT STDMETHODCALLTYPE Initialize( 
            /* [retval][out] */ LONG *result) = 0;
        
        virtual /* [source][helpstring] */ HRESULT STDMETHODCALLTYPE Finalize( 
            /* [retval][out] */ LONG *result) = 0;
        
        virtual /* [source][helpstring] */ HRESULT STDMETHODCALLTYPE GetReaderName( 
            /* [in] */ LONG index,
            /* [out] */ BSTR *readerName,
            /* [retval][out] */ LONG *result) = 0;
        
        virtual /* [source][helpstring] */ HRESULT STDMETHODCALLTYPE SelectReader( 
            /* [in] */ BSTR readerName,
            /* [retval][out] */ LONG *result) = 0;
        
        virtual /* [source][helpstring] */ HRESULT STDMETHODCALLTYPE ProcessNewCard( 
            /* [retval][out] */ LONG *result) = 0;
        
        virtual /* [source][helpstring] */ HRESULT STDMETHODCALLTYPE ReadRegistration( 
            /* [in] */ LONG index,
            /* [out] */ REGISTRATION_DATA *data,
            /* [retval][out] */ LONG *result) = 0;
        
        virtual /* [source][helpstring] */ HRESULT STDMETHODCALLTYPE ReadDocumentData( 
            /* [out] */ DOCUMENT_DATA *data,
            /* [retval][out] */ LONG *result) = 0;
        
        virtual /* [source][helpstring] */ HRESULT STDMETHODCALLTYPE ReadVehicleData( 
            /* [out] */ VEHICLE_DATA *data,
            /* [retval][out] */ LONG *result) = 0;
        
        virtual /* [source][helpstring] */ HRESULT STDMETHODCALLTYPE ReadPersonalData( 
            /* [out] */ PERSONAL_DATA *data,
            /* [retval][out] */ LONG *result) = 0;
        
    };
    
#else 	/* C style interface */

    typedef struct IRegistrationVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IRegistration * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ 
            __RPC__deref_out  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IRegistration * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IRegistration * This);
        
        /* [source][helpstring] */ HRESULT ( STDMETHODCALLTYPE *Initialize )( 
            IRegistration * This,
            /* [retval][out] */ LONG *result);
        
        /* [source][helpstring] */ HRESULT ( STDMETHODCALLTYPE *Finalize )( 
            IRegistration * This,
            /* [retval][out] */ LONG *result);
        
        /* [source][helpstring] */ HRESULT ( STDMETHODCALLTYPE *GetReaderName )( 
            IRegistration * This,
            /* [in] */ LONG index,
            /* [out] */ BSTR *readerName,
            /* [retval][out] */ LONG *result);
        
        /* [source][helpstring] */ HRESULT ( STDMETHODCALLTYPE *SelectReader )( 
            IRegistration * This,
            /* [in] */ BSTR readerName,
            /* [retval][out] */ LONG *result);
        
        /* [source][helpstring] */ HRESULT ( STDMETHODCALLTYPE *ProcessNewCard )( 
            IRegistration * This,
            /* [retval][out] */ LONG *result);
        
        /* [source][helpstring] */ HRESULT ( STDMETHODCALLTYPE *ReadRegistration )( 
            IRegistration * This,
            /* [in] */ LONG index,
            /* [out] */ REGISTRATION_DATA *data,
            /* [retval][out] */ LONG *result);
        
        /* [source][helpstring] */ HRESULT ( STDMETHODCALLTYPE *ReadDocumentData )( 
            IRegistration * This,
            /* [out] */ DOCUMENT_DATA *data,
            /* [retval][out] */ LONG *result);
        
        /* [source][helpstring] */ HRESULT ( STDMETHODCALLTYPE *ReadVehicleData )( 
            IRegistration * This,
            /* [out] */ VEHICLE_DATA *data,
            /* [retval][out] */ LONG *result);
        
        /* [source][helpstring] */ HRESULT ( STDMETHODCALLTYPE *ReadPersonalData )( 
            IRegistration * This,
            /* [out] */ PERSONAL_DATA *data,
            /* [retval][out] */ LONG *result);
        
        END_INTERFACE
    } IRegistrationVtbl;

    interface IRegistration
    {
        CONST_VTBL struct IRegistrationVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IRegistration_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define IRegistration_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define IRegistration_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define IRegistration_Initialize(This,result)	\
    ( (This)->lpVtbl -> Initialize(This,result) ) 

#define IRegistration_Finalize(This,result)	\
    ( (This)->lpVtbl -> Finalize(This,result) ) 

#define IRegistration_GetReaderName(This,index,readerName,result)	\
    ( (This)->lpVtbl -> GetReaderName(This,index,readerName,result) ) 

#define IRegistration_SelectReader(This,readerName,result)	\
    ( (This)->lpVtbl -> SelectReader(This,readerName,result) ) 

#define IRegistration_ProcessNewCard(This,result)	\
    ( (This)->lpVtbl -> ProcessNewCard(This,result) ) 

#define IRegistration_ReadRegistration(This,index,data,result)	\
    ( (This)->lpVtbl -> ReadRegistration(This,index,data,result) ) 

#define IRegistration_ReadDocumentData(This,data,result)	\
    ( (This)->lpVtbl -> ReadDocumentData(This,data,result) ) 

#define IRegistration_ReadVehicleData(This,data,result)	\
    ( (This)->lpVtbl -> ReadVehicleData(This,data,result) ) 

#define IRegistration_ReadPersonalData(This,data,result)	\
    ( (This)->lpVtbl -> ReadPersonalData(This,data,result) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __IRegistration_INTERFACE_DEFINED__ */



#ifndef __eVehicleRegistrationCOM_LIBRARY_DEFINED__
#define __eVehicleRegistrationCOM_LIBRARY_DEFINED__

/* library eVehicleRegistrationCOM */
/* [helpstring][version][uuid] */ 


EXTERN_C const IID LIBID_eVehicleRegistrationCOM;

EXTERN_C const CLSID CLSID_Registration;

#ifdef __cplusplus

class DECLSPEC_UUID("0BE1D001-F522-44E7-B956-F1E8A52179E0")
Registration;
#endif
#endif /* __eVehicleRegistrationCOM_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

unsigned long             __RPC_USER  BSTR_UserSize(     unsigned long *, unsigned long            , BSTR * ); 
unsigned char * __RPC_USER  BSTR_UserMarshal(  unsigned long *, unsigned char *, BSTR * ); 
unsigned char * __RPC_USER  BSTR_UserUnmarshal(unsigned long *, unsigned char *, BSTR * ); 
void                      __RPC_USER  BSTR_UserFree(     unsigned long *, BSTR * ); 

unsigned long             __RPC_USER  VARIANT_UserSize(     unsigned long *, unsigned long            , VARIANT * ); 
unsigned char * __RPC_USER  VARIANT_UserMarshal(  unsigned long *, unsigned char *, VARIANT * ); 
unsigned char * __RPC_USER  VARIANT_UserUnmarshal(unsigned long *, unsigned char *, VARIANT * ); 
void                      __RPC_USER  VARIANT_UserFree(     unsigned long *, VARIANT * ); 

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


