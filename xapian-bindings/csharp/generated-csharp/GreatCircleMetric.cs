//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.13
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Xapian {

public class GreatCircleMetric : LatLongMetric {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal GreatCircleMetric(global::System.IntPtr cPtr, bool cMemoryOwn) : base(XapianPINVOKE.GreatCircleMetric_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GreatCircleMetric obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GreatCircleMetric() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          XapianPINVOKE.delete_GreatCircleMetric(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public GreatCircleMetric() : this(XapianPINVOKE.new_GreatCircleMetric__SWIG_0(), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public GreatCircleMetric(double radius_) : this(XapianPINVOKE.new_GreatCircleMetric__SWIG_1(radius_), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public override double PointwiseDistance(LatLongCoord a, LatLongCoord b) {
    double ret = XapianPINVOKE.GreatCircleMetric_PointwiseDistance(swigCPtr, LatLongCoord.getCPtr(a), LatLongCoord.getCPtr(b));
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string Name() {
    string ret = XapianPINVOKE.GreatCircleMetric_Name(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}