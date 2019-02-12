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

public class Weight : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Weight(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Weight obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Weight() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          XapianPINVOKE.delete_Weight(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual string Name() {
    string ret = XapianPINVOKE.Weight_Name(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetSumPart(uint wdf, uint doclen, uint uniqterms) {
    double ret = XapianPINVOKE.Weight_GetSumPart(swigCPtr, wdf, doclen, uniqterms);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetMaxPart() {
    double ret = XapianPINVOKE.Weight_GetMaxPart(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetSumExtra(uint doclen, uint uniqterms) {
    double ret = XapianPINVOKE.Weight_GetSumExtra(swigCPtr, doclen, uniqterms);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double GetMaxExtra() {
    double ret = XapianPINVOKE.Weight_GetMaxExtra(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum type_smoothing {
    TWO_STAGE_SMOOTHING = 1,
    DIRICHLET_SMOOTHING = 2,
    ABSOLUTE_DISCOUNT_SMOOTHING = 3,
    JELINEK_MERCER_SMOOTHING = 4,
    DIRICHLET_PLUS_SMOOTHING = 5
  }

}

}
