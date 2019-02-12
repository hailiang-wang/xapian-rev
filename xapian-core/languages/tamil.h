/* This file was generated automatically by the Snowball to ISO C++ compiler */
/* http://snowballstem.org/ */

#include "steminternal.h"

namespace Xapian {

class InternalStemTamil : public SnowballStemImplementation {
    unsigned char B_found_vetrumai_urupu;
    unsigned char B_found_a_match;
    int r_has_min_length();
    int r_remove_common_word_endings();
    int r_remove_tense_suffixes();
    int r_remove_tense_suffix();
    int r_fix_endings();
    int r_fix_ending();
    int r_fix_va_start();
    int r_remove_vetrumai_urupukal();
    int r_remove_um();
    int r_remove_command_suffixes();
    int r_remove_pronoun_prefixes();
    int r_remove_question_prefixes();
    int r_remove_question_suffixes();
    int r_remove_plural_suffix();

  public:

    InternalStemTamil();
    ~InternalStemTamil();
    int stem();
    std::string get_description() const;
};

}