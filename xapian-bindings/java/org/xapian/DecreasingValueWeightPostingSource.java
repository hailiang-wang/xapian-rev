/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.13
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.xapian;

public class DecreasingValueWeightPostingSource extends ValueWeightPostingSource {
  private transient long swigCPtr;

  protected DecreasingValueWeightPostingSource(long cPtr, boolean cMemoryOwn) {
    super(XapianJNI.DecreasingValueWeightPostingSource_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(DecreasingValueWeightPostingSource obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        XapianJNI.delete_DecreasingValueWeightPostingSource(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public DecreasingValueWeightPostingSource(int slot_, long range_start_, long range_end_) {
    this(XapianJNI.new_DecreasingValueWeightPostingSource__SWIG_0(slot_, range_start_, range_end_), true);
  }

  public DecreasingValueWeightPostingSource(int slot_, long range_start_) {
    this(XapianJNI.new_DecreasingValueWeightPostingSource__SWIG_1(slot_, range_start_), true);
  }

  public DecreasingValueWeightPostingSource(int slot_) {
    this(XapianJNI.new_DecreasingValueWeightPostingSource__SWIG_2(slot_), true);
  }

  public double getWeight() {
    return XapianJNI.DecreasingValueWeightPostingSource_getWeight(swigCPtr, this);
  }

  public String name() {
    return XapianJNI.DecreasingValueWeightPostingSource_name(swigCPtr, this);
  }

  public void init(Database db_) {
    XapianJNI.DecreasingValueWeightPostingSource_init(swigCPtr, this, Database.getCPtr(db_), db_);
  }

  public void next(double min_wt) {
    XapianJNI.DecreasingValueWeightPostingSource_next(swigCPtr, this, min_wt);
  }

  public void skipTo(long min_docid, double min_wt) {
    XapianJNI.DecreasingValueWeightPostingSource_skipTo(swigCPtr, this, min_docid, min_wt);
  }

  public boolean check(long min_docid, double min_wt) {
    return XapianJNI.DecreasingValueWeightPostingSource_check(swigCPtr, this, min_docid, min_wt);
  }

  public String toString() {
    return XapianJNI.DecreasingValueWeightPostingSource_toString(swigCPtr, this);
  }

}
