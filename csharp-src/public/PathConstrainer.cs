/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/
// This File has been auto-generated by SWIG and then modified using DALi Ruby Scripts
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

public class PathConstrainer : Handle {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PathConstrainer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.PathConstrainer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PathConstrainer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PathConstrainer() {
    DisposeQueue.Instance.Add(this);
  }

  public override void Dispose() {
    if (!Stage.IsInstalled()) {
      DisposeQueue.Instance.Add(this);
      return;
    }

    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_PathConstrainer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }


  public class Property : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Property(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Property obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Property() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            NDalicPINVOKE.delete_PathConstrainer_Property(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public Property() : this(NDalicPINVOKE.new_PathConstrainer_Property(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public static readonly int FORWARD = NDalicPINVOKE.PathConstrainer_Property_FORWARD_get();
    public static readonly int POINTS = NDalicPINVOKE.PathConstrainer_Property_POINTS_get();
    public static readonly int CONTROL_POINTS = NDalicPINVOKE.PathConstrainer_Property_CONTROL_POINTS_get();
  
  }

  public PathConstrainer () : this (NDalicPINVOKE.PathConstrainer_New(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

  }
  public new static PathConstrainer DownCast(BaseHandle handle) {
    PathConstrainer ret = new PathConstrainer(NDalicPINVOKE.PathConstrainer_DownCast(BaseHandle.getCPtr(handle)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PathConstrainer(PathConstrainer handle) : this(NDalicPINVOKE.new_PathConstrainer__SWIG_1(PathConstrainer.getCPtr(handle)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public PathConstrainer Assign(PathConstrainer rhs) {
    PathConstrainer ret = new PathConstrainer(NDalicPINVOKE.PathConstrainer_Assign(swigCPtr, PathConstrainer.getCPtr(rhs)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Apply(Property target, Property source, Vector2 range, Vector2 wrap) {
    NDalicPINVOKE.PathConstrainer_Apply__SWIG_0(swigCPtr, Property.getCPtr(target), Property.getCPtr(source), Vector2.getCPtr(range), Vector2.getCPtr(wrap));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Apply(Property target, Property source, Vector2 range) {
    NDalicPINVOKE.PathConstrainer_Apply__SWIG_1(swigCPtr, Property.getCPtr(target), Property.getCPtr(source), Vector2.getCPtr(range));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Remove(Handle target) {
    NDalicPINVOKE.PathConstrainer_Remove(swigCPtr, Handle.getCPtr(target));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector3 Forward 
  { 
    get 
    {
      Vector3 temp = new Vector3(0.0f,0.0f,0.0f);
      GetProperty( PathConstrainer.Property.FORWARD).Get(  temp );
      return temp;
    }
    set 
    { 
      SetProperty( PathConstrainer.Property.FORWARD, new Dali.Property.Value( value ) );
    }
  }
  public Dali.Property.Array Points 
  { 
    get 
    {
      Dali.Property.Array temp = new Dali.Property.Array();
      GetProperty( PathConstrainer.Property.POINTS).Get(  temp );
      return temp;
    }
    set 
    { 
      SetProperty( PathConstrainer.Property.POINTS, new Dali.Property.Value( value ) );
    }
  }
  public Dali.Property.Array ControlPoints 
  { 
    get 
    {
      Dali.Property.Array temp = new Dali.Property.Array();
      GetProperty( PathConstrainer.Property.CONTROL_POINTS).Get(  temp );
      return temp;
    }
    set 
    { 
      SetProperty( PathConstrainer.Property.CONTROL_POINTS, new Dali.Property.Value( value ) );
    }
  }

}

}
