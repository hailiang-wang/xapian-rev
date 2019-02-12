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

public class Database : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Database(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Database obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Database() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          XapianPINVOKE.delete_Database(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public void AddDatabase(Database database) {
    XapianPINVOKE.Database_AddDatabase(swigCPtr, Database.getCPtr(database));
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Database() : this(XapianPINVOKE.new_Database__SWIG_0(), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Database(string path, int flags) : this(XapianPINVOKE.new_Database__SWIG_1(path, flags), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Database(string path) : this(XapianPINVOKE.new_Database__SWIG_2(path), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Database(int fd, int flags) : this(XapianPINVOKE.new_Database__SWIG_3(fd, flags), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Database(int fd) : this(XapianPINVOKE.new_Database__SWIG_4(fd), true) {
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Reopen() {
    bool ret = XapianPINVOKE.Database_Reopen(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void Close() {
    XapianPINVOKE.Database_Close(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string GetDescription() {
    string ret = XapianPINVOKE.Database_GetDescription(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PostingIterator PostListBegin(string tname) {
    PostingIterator ret = new PostingIterator(XapianPINVOKE.Database_PostListBegin(swigCPtr, tname), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PostingIterator PostListEnd(string arg0) {
    PostingIterator ret = new PostingIterator(XapianPINVOKE.Database_PostListEnd(swigCPtr, arg0), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator TermListBegin(uint did) {
    TermIterator ret = new TermIterator(XapianPINVOKE.Database_TermListBegin(swigCPtr, did), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator TermListEnd(uint arg0) {
    TermIterator ret = new TermIterator(XapianPINVOKE.Database_TermListEnd(swigCPtr, arg0), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasPositions() {
    bool ret = XapianPINVOKE.Database_HasPositions(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PositionIterator PositionListBegin(uint did, string tname) {
    PositionIterator ret = new PositionIterator(XapianPINVOKE.Database_PositionListBegin(swigCPtr, did, tname), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PositionIterator PositionListEnd(uint arg0, string arg1) {
    PositionIterator ret = new PositionIterator(XapianPINVOKE.Database_PositionListEnd(swigCPtr, arg0, arg1), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator AllTermsBegin(string prefix) {
    TermIterator ret = new TermIterator(XapianPINVOKE.Database_AllTermsBegin__SWIG_0(swigCPtr, prefix), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator AllTermsBegin() {
    TermIterator ret = new TermIterator(XapianPINVOKE.Database_AllTermsBegin__SWIG_1(swigCPtr), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator AllTermsEnd(string arg0) {
    TermIterator ret = new TermIterator(XapianPINVOKE.Database_AllTermsEnd__SWIG_0(swigCPtr, arg0), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator AllTermsEnd() {
    TermIterator ret = new TermIterator(XapianPINVOKE.Database_AllTermsEnd__SWIG_1(swigCPtr), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetDocCount() {
    uint ret = XapianPINVOKE.Database_GetDocCount(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetLastDocId() {
    uint ret = XapianPINVOKE.Database_GetLastDocId(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double GetAvLength() {
    double ret = XapianPINVOKE.Database_GetAvLength(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetTotalLength() {
    uint ret = XapianPINVOKE.Database_GetTotalLength(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetTermFreq(string tname) {
    uint ret = XapianPINVOKE.Database_GetTermFreq(swigCPtr, tname);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool TermExists(string tname) {
    bool ret = XapianPINVOKE.Database_TermExists(swigCPtr, tname);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetCollectionFreq(string tname) {
    uint ret = XapianPINVOKE.Database_GetCollectionFreq(swigCPtr, tname);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetValueFreq(uint slot) {
    uint ret = XapianPINVOKE.Database_GetValueFreq(swigCPtr, slot);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetValueLowerBound(uint slot) {
    string ret = XapianPINVOKE.Database_GetValueLowerBound(swigCPtr, slot);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetValueUpperBound(uint slot) {
    string ret = XapianPINVOKE.Database_GetValueUpperBound(swigCPtr, slot);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetDoclengthLowerBound() {
    uint ret = XapianPINVOKE.Database_GetDoclengthLowerBound(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetDoclengthUpperBound() {
    uint ret = XapianPINVOKE.Database_GetDoclengthUpperBound(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetWdfUpperBound(string term) {
    uint ret = XapianPINVOKE.Database_GetWdfUpperBound(swigCPtr, term);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ValueIterator ValuestreamBegin(uint slot) {
    ValueIterator ret = new ValueIterator(XapianPINVOKE.Database_ValuestreamBegin(swigCPtr, slot), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ValueIterator ValuestreamEnd(uint arg0) {
    ValueIterator ret = new ValueIterator(XapianPINVOKE.Database_ValuestreamEnd(swigCPtr, arg0), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetDocLength(uint did) {
    uint ret = XapianPINVOKE.Database_GetDocLength(swigCPtr, did);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetUniqueTerms(uint did) {
    uint ret = XapianPINVOKE.Database_GetUniqueTerms(swigCPtr, did);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void KeepAlive() {
    XapianPINVOKE.Database_KeepAlive(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public Document GetDocument(uint did) {
    Document ret = new Document(XapianPINVOKE.Database_GetDocument__SWIG_0(swigCPtr, did), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Document GetDocument(uint did, uint flags) {
    Document ret = new Document(XapianPINVOKE.Database_GetDocument__SWIG_1(swigCPtr, did, flags), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetSpellingSuggestion(string word, uint max_edit_distance) {
    string ret = XapianPINVOKE.Database_GetSpellingSuggestion__SWIG_0(swigCPtr, word, max_edit_distance);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetSpellingSuggestion(string word) {
    string ret = XapianPINVOKE.Database_GetSpellingSuggestion__SWIG_1(swigCPtr, word);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator SpellingsBegin() {
    TermIterator ret = new TermIterator(XapianPINVOKE.Database_SpellingsBegin(swigCPtr), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator SpellingsEnd() {
    TermIterator ret = new TermIterator(XapianPINVOKE.Database_SpellingsEnd(swigCPtr), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator SynonymsBegin(string term) {
    TermIterator ret = new TermIterator(XapianPINVOKE.Database_SynonymsBegin(swigCPtr, term), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator SynonymsEnd(string arg0) {
    TermIterator ret = new TermIterator(XapianPINVOKE.Database_SynonymsEnd(swigCPtr, arg0), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator SynonymKeysBegin(string prefix) {
    TermIterator ret = new TermIterator(XapianPINVOKE.Database_SynonymKeysBegin__SWIG_0(swigCPtr, prefix), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator SynonymKeysBegin() {
    TermIterator ret = new TermIterator(XapianPINVOKE.Database_SynonymKeysBegin__SWIG_1(swigCPtr), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator SynonymKeysEnd(string arg0) {
    TermIterator ret = new TermIterator(XapianPINVOKE.Database_SynonymKeysEnd__SWIG_0(swigCPtr, arg0), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator SynonymKeysEnd() {
    TermIterator ret = new TermIterator(XapianPINVOKE.Database_SynonymKeysEnd__SWIG_1(swigCPtr), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetMetadata(string key) {
    string ret = XapianPINVOKE.Database_GetMetadata(swigCPtr, key);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator MetadataKeysBegin(string prefix) {
    TermIterator ret = new TermIterator(XapianPINVOKE.Database_MetadataKeysBegin__SWIG_0(swigCPtr, prefix), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator MetadataKeysBegin() {
    TermIterator ret = new TermIterator(XapianPINVOKE.Database_MetadataKeysBegin__SWIG_1(swigCPtr), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator MetadataKeysEnd(string arg0) {
    TermIterator ret = new TermIterator(XapianPINVOKE.Database_MetadataKeysEnd__SWIG_0(swigCPtr, arg0), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TermIterator MetadataKeysEnd() {
    TermIterator ret = new TermIterator(XapianPINVOKE.Database_MetadataKeysEnd__SWIG_1(swigCPtr), true);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetUuid() {
    string ret = XapianPINVOKE.Database_GetUuid(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Locked() {
    bool ret = XapianPINVOKE.Database_Locked(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint GetRevision() {
    uint ret = XapianPINVOKE.Database_GetRevision(swigCPtr);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static uint Check(string path, int opts) {
    uint ret = XapianPINVOKE.Database_Check__SWIG_0(path, opts);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static uint Check(string path) {
    uint ret = XapianPINVOKE.Database_Check__SWIG_1(path);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static uint Check(int fd, int opts) {
    uint ret = XapianPINVOKE.Database_Check__SWIG_2(fd, opts);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static uint Check(int fd) {
    uint ret = XapianPINVOKE.Database_Check__SWIG_3(fd);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Compact(string output, uint flags, int block_size) {
    XapianPINVOKE.Database_Compact__SWIG_0(swigCPtr, output, flags, block_size);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Compact(string output, uint flags) {
    XapianPINVOKE.Database_Compact__SWIG_1(swigCPtr, output, flags);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Compact(string output) {
    XapianPINVOKE.Database_Compact__SWIG_2(swigCPtr, output);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Compact(int fd, uint flags, int block_size) {
    XapianPINVOKE.Database_Compact__SWIG_3(swigCPtr, fd, flags, block_size);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Compact(int fd, uint flags) {
    XapianPINVOKE.Database_Compact__SWIG_4(swigCPtr, fd, flags);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Compact(int fd) {
    XapianPINVOKE.Database_Compact__SWIG_5(swigCPtr, fd);
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Compact(string output, uint flags, int block_size, Compactor compactor) {
    XapianPINVOKE.Database_Compact__SWIG_6(swigCPtr, output, flags, block_size, Compactor.getCPtr(compactor));
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Compact(int fd, uint flags, int block_size, Compactor compactor) {
    XapianPINVOKE.Database_Compact__SWIG_7(swigCPtr, fd, flags, block_size, Compactor.getCPtr(compactor));
    if (XapianPINVOKE.SWIGPendingException.Pending) throw XapianPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
