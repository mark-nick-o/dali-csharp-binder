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

public class Vector4 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Vector4(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Vector4 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Vector4() {
    DisposeQueue.Instance.Add(this);
  }

  public virtual void Dispose() {
    if (!Stage.IsInstalled()) {
      DisposeQueue.Instance.Add(this);
      return;
    }

    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_Vector4(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }


  public static Vector4 operator+(Vector4 arg1, Vector4 arg2) {
    return arg1.Add(arg2);
  }

  public static Vector4 operator-(Vector4 arg1, Vector4 arg2) {
    return arg1.Subtract(arg2);
  }

  public static Vector4 operator-(Vector4 arg1) {
    return arg1.Subtract();
  }

  public static Vector4 operator*(Vector4 arg1, Vector4 arg2) {
    return arg1.Multiply(arg2);
  }

  public static Vector4 operator*(Vector4 arg1, float arg2) {
    return arg1.Multiply(arg2);
  }

  public static Vector4 operator/(Vector4 arg1, Vector4 arg2) {
    return arg1.Divide(arg2);
  }

  public static Vector4 operator/(Vector4 arg1, float arg2) {
    return arg1.Divide(arg2);
  }

  public float this[uint index]
  {
    get
    {
      return ValueOfIndex(index);
    }
  }

  public static Vector4 GetVector4FromPtr(global::System.IntPtr cPtr) {
    Vector4 ret = new Vector4(cPtr, false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
       return ret;
  }


  public Vector4() : this(NDalicPINVOKE.new_Vector4__SWIG_0(), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector4(float x, float y, float z, float w) : this(NDalicPINVOKE.new_Vector4__SWIG_1(x, y, z, w), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector4(float[] array) : this(NDalicPINVOKE.new_Vector4__SWIG_2(array), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector4(Vector2 vec2) : this(NDalicPINVOKE.new_Vector4__SWIG_3(Vector2.getCPtr(vec2)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector4(Vector3 vec3) : this(NDalicPINVOKE.new_Vector4__SWIG_4(Vector3.getCPtr(vec3)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public static Vector4 ONE {
    get {
      global::System.IntPtr cPtr = NDalicPINVOKE.Vector4_ONE_get();
      Vector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector4(cPtr, false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static Vector4 XAXIS {
    get {
      global::System.IntPtr cPtr = NDalicPINVOKE.Vector4_XAXIS_get();
      Vector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector4(cPtr, false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static Vector4 YAXIS {
    get {
      global::System.IntPtr cPtr = NDalicPINVOKE.Vector4_YAXIS_get();
      Vector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector4(cPtr, false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static Vector4 ZAXIS {
    get {
      global::System.IntPtr cPtr = NDalicPINVOKE.Vector4_ZAXIS_get();
      Vector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector4(cPtr, false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static Vector4 ZERO {
    get {
      global::System.IntPtr cPtr = NDalicPINVOKE.Vector4_ZERO_get();
      Vector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector4(cPtr, false);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public Vector4 Assign(float[] array) {
    Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_Assign__SWIG_0(swigCPtr, array), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 Assign(Vector2 vec2) {
    Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_Assign__SWIG_1(swigCPtr, Vector2.getCPtr(vec2)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 Assign(Vector3 vec3) {
    Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_Assign__SWIG_2(swigCPtr, Vector3.getCPtr(vec3)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 Add(Vector4 rhs) {
    Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_Add(swigCPtr, Vector4.getCPtr(rhs)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 AddAssign(Vector4 rhs) {
    Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_AddAssign(swigCPtr, Vector4.getCPtr(rhs)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 Subtract(Vector4 rhs) {
    Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_Subtract__SWIG_0(swigCPtr, Vector4.getCPtr(rhs)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 SubtractAssign(Vector4 rhs) {
    Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_SubtractAssign(swigCPtr, Vector4.getCPtr(rhs)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 Multiply(Vector4 rhs) {
    Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_Multiply__SWIG_0(swigCPtr, Vector4.getCPtr(rhs)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 Multiply(float rhs) {
    Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_Multiply__SWIG_1(swigCPtr, rhs), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 MultiplyAssign(Vector4 rhs) {
    Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_MultiplyAssign__SWIG_0(swigCPtr, Vector4.getCPtr(rhs)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 MultiplyAssign(float rhs) {
    Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_MultiplyAssign__SWIG_1(swigCPtr, rhs), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 Divide(Vector4 rhs) {
    Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_Divide__SWIG_0(swigCPtr, Vector4.getCPtr(rhs)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 Divide(float rhs) {
    Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_Divide__SWIG_1(swigCPtr, rhs), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 DivideAssign(Vector4 rhs) {
    Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_DivideAssign__SWIG_0(swigCPtr, Vector4.getCPtr(rhs)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 DivideAssign(float rhs) {
    Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_DivideAssign__SWIG_1(swigCPtr, rhs), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 Subtract() {
    Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_Subtract__SWIG_1(swigCPtr), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool EqualTo(Vector4 rhs) {
    bool ret = NDalicPINVOKE.Vector4_EqualTo(swigCPtr, Vector4.getCPtr(rhs));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool NotEqualTo(Vector4 rhs) {
    bool ret = NDalicPINVOKE.Vector4_NotEqualTo(swigCPtr, Vector4.getCPtr(rhs));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float ValueOfIndex(uint index) {
    float ret = NDalicPINVOKE.Vector4_ValueOfIndex__SWIG_0(swigCPtr, index);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float Dot(Vector3 other) {
    float ret = NDalicPINVOKE.Vector4_Dot__SWIG_0(swigCPtr, Vector3.getCPtr(other));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float Dot(Vector4 other) {
    float ret = NDalicPINVOKE.Vector4_Dot__SWIG_1(swigCPtr, Vector4.getCPtr(other));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float Dot4(Vector4 other) {
    float ret = NDalicPINVOKE.Vector4_Dot4(swigCPtr, Vector4.getCPtr(other));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector4 Cross(Vector4 other) {
    Vector4 ret = new Vector4(NDalicPINVOKE.Vector4_Cross(swigCPtr, Vector4.getCPtr(other)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float Length() {
    float ret = NDalicPINVOKE.Vector4_Length(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float LengthSquared() {
    float ret = NDalicPINVOKE.Vector4_LengthSquared(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Normalize() {
    NDalicPINVOKE.Vector4_Normalize(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clamp(Vector4 min, Vector4 max) {
    NDalicPINVOKE.Vector4_Clamp(swigCPtr, Vector4.getCPtr(min), Vector4.getCPtr(max));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_float AsFloat() {
    global::System.IntPtr cPtr = NDalicPINVOKE.Vector4_AsFloat__SWIG_0(swigCPtr);
    SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float X {
    set {
      NDalicPINVOKE.Vector4_X_set(swigCPtr, value);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NDalicPINVOKE.Vector4_X_get(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float r {
    set {
      NDalicPINVOKE.Vector4_r_set(swigCPtr, value);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NDalicPINVOKE.Vector4_r_get(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float s {
    set {
      NDalicPINVOKE.Vector4_s_set(swigCPtr, value);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NDalicPINVOKE.Vector4_s_get(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float Y {
    set {
      NDalicPINVOKE.Vector4_Y_set(swigCPtr, value);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NDalicPINVOKE.Vector4_Y_get(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float g {
    set {
      NDalicPINVOKE.Vector4_g_set(swigCPtr, value);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NDalicPINVOKE.Vector4_g_get(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float t {
    set {
      NDalicPINVOKE.Vector4_t_set(swigCPtr, value);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NDalicPINVOKE.Vector4_t_get(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float Z {
    set {
      NDalicPINVOKE.Vector4_Z_set(swigCPtr, value);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NDalicPINVOKE.Vector4_Z_get(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float b {
    set {
      NDalicPINVOKE.Vector4_b_set(swigCPtr, value);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NDalicPINVOKE.Vector4_b_get(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float p {
    set {
      NDalicPINVOKE.Vector4_p_set(swigCPtr, value);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NDalicPINVOKE.Vector4_p_get(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float W {
    set {
      NDalicPINVOKE.Vector4_W_set(swigCPtr, value);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NDalicPINVOKE.Vector4_W_get(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float a {
    set {
      NDalicPINVOKE.Vector4_a_set(swigCPtr, value);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NDalicPINVOKE.Vector4_a_get(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float q {
    set {
      NDalicPINVOKE.Vector4_q_set(swigCPtr, value);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = NDalicPINVOKE.Vector4_q_get(swigCPtr);
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}

}
