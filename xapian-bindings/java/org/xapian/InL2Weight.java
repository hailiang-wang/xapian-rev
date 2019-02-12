/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.13
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.xapian;

public class InL2Weight extends Weight {
  private transient long swigCPtr;

  protected InL2Weight(long cPtr, boolean cMemoryOwn) {
    super(XapianJNI.InL2Weight_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(InL2Weight obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        XapianJNI.delete_InL2Weight(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public InL2Weight(double c) {
    this(XapianJNI.new_InL2Weight__SWIG_0(c), true);
  }

  public InL2Weight() {
    this(XapianJNI.new_InL2Weight__SWIG_1(), true);
  }

  public String name() {
    return XapianJNI.InL2Weight_name(swigCPtr, this);
  }

  public double getSumPart(long wdf, long doclen, long uniqterms) {
    return XapianJNI.InL2Weight_getSumPart(swigCPtr, this, wdf, doclen, uniqterms);
  }

  public double getMaxPart() {
    return XapianJNI.InL2Weight_getMaxPart(swigCPtr, this);
  }

  public double getSumExtra(long doclen, long uniqterms) {
    return XapianJNI.InL2Weight_getSumExtra(swigCPtr, this, doclen, uniqterms);
  }

  public double getMaxExtra() {
    return XapianJNI.InL2Weight_getMaxExtra(swigCPtr, this);
  }

}
