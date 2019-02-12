%{
/** @file generic/except.i
 * @brief Language independent exception handling.
 */
/* Warning: This file is generated by ./generic/generate-generic-exceptions
 * - do not modify directly!
 *
 * Copyright (C) 2004,2005,2006,2007,2011,2012,2018 Olly Betts
 * Copyright (C) 2007 Lemur Consulting Ltd
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License as
 * published by the Free Software Foundation; either version 2 of the
 * License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301 USA
 */

/* This file is included for any languages which don't have language specific
 * handling for exceptions.
 */

#include <exception>

static int XapianExceptionHandler(string & msg) {
    try {
	// Rethrow so we can look at the exception if it was a Xapian::Error.
	throw;
    } catch (const Xapian::Error &e) {
	msg = e.get_description();
	try {
	    // Re-rethrow the previous exception so we can handle the type in a
	    // fine-grained way, but only in one place to avoid bloating the
	    // file.
	    throw;
	} catch (const Xapian::InvalidArgumentError &) {
	    return SWIG_ValueError;
	} catch (const Xapian::RangeError &) {
	    return SWIG_IndexError;
	} catch (const Xapian::DatabaseError &) {
	    return SWIG_IOError;
	} catch (const Xapian::NetworkError &) {
	    return SWIG_IOError;
	} catch (const Xapian::InternalError &) {
	    return SWIG_RuntimeError;
	} catch (const Xapian::RuntimeError &) {
	    return SWIG_RuntimeError;
	} catch (...) {
	    return SWIG_UnknownError;
	}
    } catch (const std::exception &e) {
	msg = "std::exception: ";
        msg += e.what();
    } catch (...) {
	msg = "unknown error in Xapian";
    }
    return SWIG_UnknownError;
}
%}

/* Functions and methods which are marked as "nothrow": */
%exception Xapian::Compactor::get_constinfo_();
%exception Xapian::Database::postlist_end(const std::string &) const;
%exception Xapian::Database::termlist_end(Xapian::docid) const;
%exception Xapian::Database::positionlist_end(Xapian::docid, const std::string &) const;
%exception Xapian::Database::allterms_end(const std::string & = std::string()) const;
%exception Xapian::Database::valuestream_end(Xapian::valueno) const;
%exception Xapian::Database::spellings_end() const;
%exception Xapian::Database::synonyms_end(const std::string &) const;
%exception Xapian::Database::synonym_keys_end(const std::string & = std::string()) const;
%exception Xapian::Database::metadata_keys_end(const std::string & = std::string()) const;
%exception Xapian::Document::termlist_end() const;
%exception Xapian::Document::values_end() const;
%exception Xapian::Enquire::get_matching_terms_end(Xapian::docid  ) const;
%exception Xapian::Enquire::get_matching_terms_end(const MSetIterator & ) const;
%exception Xapian::Error::get_type() const;
%exception Xapian::Error::get_msg() const;
%exception Xapian::Error::get_context() const;
%exception Xapian::ErrorHandler::ErrorHandler();
%exception Xapian::ESetIterator::operator==(const ESetIterator &a, const ESetIterator &b);
%exception Xapian::ESetIterator::operator!=(const ESetIterator &a, const ESetIterator &b);
%exception Xapian::ESetIterator::operator<(const ESetIterator &a, const ESetIterator &b);
%exception Xapian::ESetIterator::operator>(const ESetIterator &a, const ESetIterator &b);
%exception Xapian::ESetIterator::operator>=(const ESetIterator &a, const ESetIterator &b);
%exception Xapian::ESetIterator::operator<=(const ESetIterator &a, const ESetIterator &b);
%exception Xapian::ExpandDeciderFilterPrefix::miles_to_metres(double miles);
%exception Xapian::ExpandDeciderFilterPrefix::metres_to_miles(double metres);
%exception Xapian::ExpandDeciderFilterPrefix::LatLongCoord();
%exception Xapian::ExpandDeciderFilterPrefix::operator<(const LatLongCoord & other) const;
%exception Xapian::MatchSpy::MatchSpy();
%exception Xapian::ValueCountMatchSpy::get_total() const;
%exception Xapian::ValueCountMatchSpy::values_end() const;
%exception Xapian::ValueCountMatchSpy::top_values_end(size_t) const;
%exception Xapian::MSetIterator::operator==(const MSetIterator &a, const MSetIterator &b);
%exception Xapian::MSetIterator::operator!=(const MSetIterator &a, const MSetIterator &b);
%exception Xapian::MSetIterator::operator<(const MSetIterator &a, const MSetIterator &b);
%exception Xapian::MSetIterator::operator>(const MSetIterator &a, const MSetIterator &b);
%exception Xapian::MSetIterator::operator>=(const MSetIterator &a, const MSetIterator &b);
%exception Xapian::MSetIterator::operator<=(const MSetIterator &a, const MSetIterator &b);
%exception Xapian::PositionIterator::PositionIterator();
%exception Xapian::PositionIterator::operator==(const PositionIterator &a, const PositionIterator &b);
%exception Xapian::PositionIterator::operator!=(const PositionIterator &a, const PositionIterator &b);
%exception Xapian::PostingIterator::PostingIterator();
%exception Xapian::PostingIterator::positionlist_end() const;
%exception Xapian::PostingIterator::operator==(const PostingIterator &a, const PostingIterator &b);
%exception Xapian::PostingIterator::operator!=(const PostingIterator &a, const PostingIterator &b);
%exception Xapian::PostingSource::PostingSource();
%exception Xapian::PostingSource::get_maxweight() const;
%exception Xapian::Query::Query();
%exception Xapian::Query::get_terms_end() const;
%exception Xapian::Query::get_length() const;
%exception Xapian::Query::empty() const;
%exception Xapian::Query::get_type() const;
%exception Xapian::Query::get_num_subqueries() const;
%exception Xapian::Query::Internal();
%exception Xapian::Query::get_length() const;
%exception Xapian::Query::get_type() const;
%exception Xapian::Query::get_num_subqueries() const;
%exception Xapian::QueryParser::stoplist_end() const;
%exception Xapian::QueryParser::unstem_end(const std::string &) const;
%exception Xapian::QueryParser::sortable_serialise_(double value, char * buf);
%exception Xapian::QueryParser::sortable_unserialise(const std::string & serialised);
%exception Xapian::TermIterator::TermIterator();
%exception Xapian::TermIterator::positionlist_end() const;
%exception Xapian::TermIterator::operator==(const TermIterator &a, const TermIterator &b);
%exception Xapian::TermIterator::operator!=(const TermIterator &a, const TermIterator &b);
%exception Xapian::Utf8Iterator::calculate_sequence_length() const;
%exception Xapian::Utf8Iterator::Utf8Iterator();
%exception Xapian::Utf8Iterator::operator*() const;
%exception Xapian::Utf8Iterator::strict_deref() const;
%exception Xapian::Utf8Iterator::operator==(const Utf8Iterator &other) const;
%exception Xapian::Utf8Iterator::operator!=(const Utf8Iterator &other) const;
%exception Xapian::Utf8Iterator::get_character_info(unsigned ch);
%exception Xapian::ValueIterator::ValueIterator();
%exception Xapian::ValueIterator::operator==(const ValueIterator &a, const ValueIterator &b);
%exception Xapian::ValueIterator::operator!=(const ValueIterator &a, const ValueIterator &b);

%exception {
    try {
	$function
    } catch (...) {
	string msg;
	int code = XapianExceptionHandler(msg);
	SWIG_exception(code, msg.c_str());
    }
}