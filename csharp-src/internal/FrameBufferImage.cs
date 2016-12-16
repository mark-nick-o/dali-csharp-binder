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

public class FrameBufferImage : Image {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FrameBufferImage(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.FrameBufferImage_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FrameBufferImage obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FrameBufferImage() {
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
          NDalicPINVOKE.delete_FrameBufferImage(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }


  public FrameBufferImage (uint width, uint height, PixelFormat pixelFormat, RenderBufferFormat bufferFormat) : this (NDalicPINVOKE.FrameBufferImage_New__SWIG_0(width, height, (int)pixelFormat, (int)bufferFormat), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

  }
  public FrameBufferImage (uint width, uint height, PixelFormat pixelFormat) : this (NDalicPINVOKE.FrameBufferImage_New__SWIG_1(width, height, (int)pixelFormat), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

  }
  public FrameBufferImage (uint width, uint height) : this (NDalicPINVOKE.FrameBufferImage_New__SWIG_2(width, height), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

  }
  public FrameBufferImage (uint width) : this (NDalicPINVOKE.FrameBufferImage_New__SWIG_3(width), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

  }
  public FrameBufferImage () : this (NDalicPINVOKE.FrameBufferImage_New__SWIG_4(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

  }
  public FrameBufferImage (NativeImageInterface image) : this (NDalicPINVOKE.FrameBufferImage_New__SWIG_5(NativeImageInterface.getCPtr(image)), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

  }
  public new static FrameBufferImage DownCast(BaseHandle handle) {
    FrameBufferImage ret = new FrameBufferImage(NDalicPINVOKE.FrameBufferImage_DownCast(BaseHandle.getCPtr(handle)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FrameBufferImage(FrameBufferImage handle) : this(NDalicPINVOKE.new_FrameBufferImage__SWIG_1(FrameBufferImage.getCPtr(handle)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public FrameBufferImage Assign(FrameBufferImage rhs) {
    FrameBufferImage ret = new FrameBufferImage(NDalicPINVOKE.FrameBufferImage_Assign(swigCPtr, FrameBufferImage.getCPtr(rhs)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
