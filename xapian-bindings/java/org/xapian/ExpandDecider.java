/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.13
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.xapian;

public class ExpandDecider {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected ExpandDecider(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(ExpandDecider obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        XapianJNI.delete_ExpandDecider(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  protected void swigDirectorDisconnect() {
    swigCMemOwn = false;
    delete();
  }

  public void swigReleaseOwnership() {
    swigCMemOwn = false;
    XapianJNI.ExpandDecider_change_ownership(this, swigCPtr, false);
  }

  public void swigTakeOwnership() {
    swigCMemOwn = true;
    XapianJNI.ExpandDecider_change_ownership(this, swigCPtr, true);
  }

  public ExpandDecider() {
    this(XapianJNI.new_ExpandDecider(), true);
    XapianJNI.ExpandDecider_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public boolean accept(String term) {
    return XapianJNI.ExpandDecider_accept(swigCPtr, this, term);
  }

  public ExpandDecider release() {
    long cPtr = XapianJNI.ExpandDecider_release(swigCPtr, this);
    return (cPtr == 0) ? null : new ExpandDecider(cPtr, false);
  }

}
