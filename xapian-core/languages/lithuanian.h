/* This file was generated automatically by the Snowball to ISO C++ compiler */
/* http://snowballstem.org/ */

#include "steminternal.h"

namespace Xapian {

class InternalStemLithuanian : public SnowballStemImplementation {
    int I_p1;
    int r_fix_conflicts();
    int r_fix_gd();
    int r_fix_chdz();
    int r_step1();
    int r_R1();
    int r_step2();

  public:

    InternalStemLithuanian();
    ~InternalStemLithuanian();
    int stem();
    std::string get_description() const;
};

}
