//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.9
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Dali {

public class TypeRegistration : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TypeRegistration(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TypeRegistration obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TypeRegistration() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_TypeRegistration(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public TypeRegistration(SWIGTYPE_p_std__type_info registerType, SWIGTYPE_p_std__type_info baseType, SWIGTYPE_p_f___Dali__BaseHandle f) : this(NDalicPINVOKE.new_TypeRegistration__SWIG_0(SWIGTYPE_p_std__type_info.getCPtr(registerType), SWIGTYPE_p_std__type_info.getCPtr(baseType), SWIGTYPE_p_f___Dali__BaseHandle.getCPtr(f)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public TypeRegistration(SWIGTYPE_p_std__type_info registerType, SWIGTYPE_p_std__type_info baseType, SWIGTYPE_p_f___Dali__BaseHandle f, bool callCreateOnInit) : this(NDalicPINVOKE.new_TypeRegistration__SWIG_1(SWIGTYPE_p_std__type_info.getCPtr(registerType), SWIGTYPE_p_std__type_info.getCPtr(baseType), SWIGTYPE_p_f___Dali__BaseHandle.getCPtr(f), callCreateOnInit), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public TypeRegistration(string name, SWIGTYPE_p_std__type_info baseType, SWIGTYPE_p_f___Dali__BaseHandle f) : this(NDalicPINVOKE.new_TypeRegistration__SWIG_2(name, SWIGTYPE_p_std__type_info.getCPtr(baseType), SWIGTYPE_p_f___Dali__BaseHandle.getCPtr(f)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public string RegisteredName() {
    string ret = NDalicPINVOKE.TypeRegistration_RegisteredName(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
